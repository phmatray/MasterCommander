var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does(() =>
{
    CleanDirectory("./.artifacts");
    CleanDirectory($"./src/library/MasterCommander/bin/{configuration}");
});

Task("Build")
    .IsDependentOn("Clean")
    .Does(context =>
{
    Information("\nCompiling MasterCommander...");
    DotNetBuild("./MasterCommander.sln", new DotNetBuildSettings {
        Configuration = configuration,
        Verbosity = DotNetVerbosity.Minimal,
        NoLogo = true,
        NoIncremental = context.HasArgument("rebuild"),
        MSBuildSettings = new DotNetMSBuildSettings()
            .TreatAllWarningsAs(MSBuildTreatAllWarningsAs.Error)
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetTest("./MasterCommander.sln", new DotNetTestSettings
    {
        Configuration = configuration,
        Verbosity = DotNetVerbosity.Minimal,
        NoLogo = true,
        NoRestore = true,
        NoBuild = true,
    });
});

Task("Package")
    .IsDependentOn("Test")
    .Does(context => 
{
    context.DotNetPack($"./MasterCommander.sln", new DotNetPackSettings {
        Configuration = configuration,
        Verbosity = DotNetVerbosity.Minimal,
        NoLogo = true,
        NoRestore = true,
        NoBuild = true,
        OutputDirectory = "./.artifacts",
        MSBuildSettings = new DotNetMSBuildSettings()
            .TreatAllWarningsAs(MSBuildTreatAllWarningsAs.Error)
    });
});

Task("Install-NuGet-Validator")
    .IsDependentOn("Package")
    .Does(() =>
{
    // Ensure the tool is installed globally
    StartProcess("dotnet", new ProcessSettings {
        Arguments = "tool update Meziantou.Framework.NuGetPackageValidation.Tool --global"
    });
});

Task("Validate-NuGet-Package")
    .IsDependentOn("Install-NuGet-Validator")
    .Does(context =>
{
    // Assuming NuGet packages are placed in "./.artifacts" directory
    var nuGetPackages = GetFiles("./.artifacts/*.nupkg");
    foreach(var package in nuGetPackages)
    {
        // Run validation for each package
        var processExitCode = StartProcess("dotnet", new ProcessSettings {
            Arguments = $"meziantou.validate-nuget-package {package}"
        });
        
        // Check if the process was successful
        if(processExitCode != 0) {
            throw new CakeException("NuGet package validation failed.");
        }
    }
});

Task("Publish-NuGet")
    .WithCriteria(ctx => BuildSystem.IsRunningOnGitHubActions, "Not running on GitHub Actions")
    .IsDependentOn("Validate-NuGet-Package")
    .Does(context => 
{
    var apiKey = Argument<string>("nuget-key", null);
    if(string.IsNullOrWhiteSpace(apiKey)) {
        throw new CakeException("No NuGet API key was provided.");
    }

    // Publish to GitHub Packages
    foreach(var file in context.GetFiles("./.artifacts/*.nupkg")) 
    {
        context.Information("Publishing {0}...", file.GetFilename().FullPath);
        DotNetNuGetPush(file.FullPath, new DotNetNuGetPushSettings
        {
            Source = "https://api.nuget.org/v3/index.json",
            ApiKey = apiKey,
        });
    }
});

//////////////////////////////////////////////////////////////////////
// TARGETS
//////////////////////////////////////////////////////////////////////

Task("Publish")
    .IsDependentOn("Publish-NuGet");
    
Task("Default")
    .IsDependentOn("Validate-NuGet-Package");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
