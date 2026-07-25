using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

// ⚠ Both workflows under .github/workflows are hand-maintained, not generated from these
// attributes — publish.yml runs NuGet/login to obtain a short-lived key through Trusted Publishing,
// which Nuke cannot express declaratively. AutoGenerate = false means nothing overwrites them on
// their own, but `nuke --generate-configuration GitHubActions_<name> --host GitHubActions` would,
// dropping the id-token permission and the login step with it. The attributes are kept because they
// document what each workflow invokes.
[GitHubActions(
    "build",
    GitHubActionsImage.UbuntuLatest,
    AutoGenerate = false,
    OnPushBranches = ["main"],
    OnPullRequestBranches = ["*"],
    InvokedTargets = [nameof(Validate)],
    FetchDepth = 0)]
[GitHubActions(
    "publish",
    GitHubActionsImage.UbuntuLatest,
    AutoGenerate = false,
    OnPushBranches = ["main"],
    OnPushTags = ["*"],
    InvokedTargets = [nameof(Publish)],
    FetchDepth = 0)]
sealed class Build : NukeBuild
{
    /// <summary>
    /// Default target when none is named — the same default the Cake script had: everything up to
    /// and including package validation, but never publishing.
    /// </summary>
    public static int Main() => Execute<Build>(x => x.Validate);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

    [Parameter("NuGet API key for publishing packages")]
    [Secret]
    readonly string? NuGetApiKey;

    [Parameter("NuGet source URL")]
    readonly string NuGetSource = "https://api.nuget.org/v3/index.json";

    [Parameter("Clean before building, and build without incrementality")]
    readonly bool Rebuild;

    [Solution]
    readonly Solution? Solution;

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath LibraryDirectory => SourceDirectory / "library" / "MasterCommander";
    AbsolutePath TestsDirectory => SourceDirectory / "tests" / "MasterCommander.Tests";

    // Kept as ./.artifacts, the path the Cake script used, so nothing outside the build has to move.
    AbsolutePath ArtifactsDirectory => RootDirectory / ".artifacts";

    /// <remarks>
    /// Only runs when --rebuild is passed, matching the Cake task's
    /// <c>WithCriteria(c => HasArgument("rebuild"))</c>. An ordinary build is incremental, as before.
    /// </remarks>
    Target Clean => _ => _
        .OnlyWhenStatic(() => Rebuild)
        .Before(Restore)
        .Executes(() =>
        {
            SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(x => x.DeleteDirectory());
            ArtifactsDirectory.CreateOrCleanDirectory();
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
        });

    /// <remarks>
    /// <c>TreatWarningsAsErrors</c> is passed as an MSBuild property rather than set in the project
    /// files, so it binds to CI and command-line builds exactly as the Cake script's
    /// <c>TreatAllWarningsAs(MSBuildTreatAllWarningsAs.Error)</c> did — an IDE build stays unaffected.
    /// </remarks>
    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(s => s
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .SetProperty("TreatWarningsAsErrors", "true")
                .EnableNoRestore()
                .EnableNoLogo()
                .SetVerbosity(DotNetVerbosity.minimal)
                .SetNoIncremental(Rebuild)
                .SetDeterministic(IsServerBuild)
                .SetContinuousIntegrationBuild(IsServerBuild));
        });

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore()
                .EnableNoBuild()
                .EnableNoLogo()
                .SetVerbosity(DotNetVerbosity.minimal));
        });

    Target Pack => _ => _
        .DependsOn(Test)
        .Produces(ArtifactsDirectory / "*.nupkg")
        .Executes(() =>
        {
            ArtifactsDirectory.CreateOrCleanDirectory();

            // Packs the solution, not the library alone: the demo and test projects both declare
            // IsPackable false, so exactly one package comes out — same as the Cake script.
            DotNetPack(s => s
                .SetProject(Solution)
                .SetConfiguration(Configuration)
                .SetProperty("TreatWarningsAsErrors", "true")
                .EnableNoRestore()
                .EnableNoBuild()
                .EnableNoLogo()
                .SetVerbosity(DotNetVerbosity.minimal)
                .SetOutputDirectory(ArtifactsDirectory)
                .SetDeterministic(IsServerBuild)
                .SetContinuousIntegrationBuild(IsServerBuild));
        });

    /// <remarks>
    /// The Cake script ran <c>dotnet tool update … --global</c> first, even though the validator is
    /// already pinned as a local tool in dotnet-tools.json. Restoring the local tool instead keeps
    /// the version the repository actually chose, rather than silently drifting to whatever is
    /// latest on the machine.
    /// </remarks>
    Target Validate => _ => _
        .DependsOn(Pack)
        .Executes(() =>
        {
            DotNet("tool restore");

            var packages = ArtifactsDirectory.GlobFiles("*.nupkg");
            Assert.NotEmpty(packages.ToList(), $"No .nupkg found under {ArtifactsDirectory}");

            packages.ForEach(package =>
            {
                Log.Information("Validating {Package}...", package.Name);
                DotNet($"meziantou.validate-nuget-package {package}");
            });
        });

    /// <remarks>
    /// The Cake script guarded this with <c>WithCriteria(BuildSystem.IsRunningOnGitHubActions)</c>,
    /// which skips silently off CI. <c>Requires</c> is used instead so a local invocation fails and
    /// says why, rather than reporting success without publishing anything.
    /// </remarks>
    Target Publish => _ => _
        .DependsOn(Validate)
        .Requires(() => NuGetApiKey)
        .Requires(() => Configuration == "Release")
        .Executes(() =>
        {
            ArtifactsDirectory.GlobFiles("*.nupkg")
                .ForEach(package =>
                {
                    Log.Information("Publishing {Package}...", package.Name);

                    DotNetNuGetPush(s => s
                        .SetTargetPath(package)
                        .SetSource(NuGetSource)
                        .SetApiKey(NuGetApiKey)
                        .EnableSkipDuplicate());
                });
        });
}
