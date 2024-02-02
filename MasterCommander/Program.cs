using MasterCommander.Integrations;
using Microsoft.Extensions.DependencyInjection;

WriteLine("\n-----------------");
WriteLine(" MasterCommander");
WriteLine("-----------------\n");

// get the required services
var services = MainExtensions.RegisterAppServices();
var git = services.GetRequiredService<IGitService>();
var dotnet = services.GetRequiredService<IDotnetService>();

// create a new .NET solution and console application
await git.InitAsync();
await git.StatusAsync();
await dotnet.NewAsync(new DotnetNewGitignoreOptions());
await dotnet.NewAsync(new DotnetNewEditorConfigOptions());
await dotnet.NewAsync(new DotnetNewGlobalJsonOptions { SdkVersion = "8.0.101" });
await dotnet.NewAsync(new DotnetNewSolutionOptions { OutputName = "AppDemo" });
await dotnet.NewAsync(new DotnetNewConsoleOptions { OutputName = "AppDemo.Console" });
await dotnet.SlnAddAsync("AppDemo.Console/AppDemo.Console.csproj");
await dotnet.BuildAsync();
await dotnet.BuildAsync(new DotnetBuildOptions { Configuration = "Release" });
await dotnet.RunAsync(new DotnetRunOptions { Project = "AppDemo.Console/AppDemo.Console.csproj", Configuration = "Release" });
