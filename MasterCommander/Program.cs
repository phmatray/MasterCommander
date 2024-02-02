using MasterCommander.Integrations;
using Microsoft.Extensions.DependencyInjection;

WriteLine("\n-----------------");
WriteLine(" MasterCommander");
WriteLine("-----------------\n");

// get the required services
var services = MainExtensions.RegisterAppServices();
var git = services.GetRequiredService<IGitService>();
var dotnet = services.GetRequiredService<IDotnetService>();
var docker = services.GetRequiredService<IDockerService>();
var npm = services.GetRequiredService<INpmService>();

await git.InitAsync();
await git.StatusAsync();
await dotnet.NewAsync(new DotnetNewGitignoreOptions());
await dotnet.NewAsync(new DotnetNewEditorConfigOptions());
await dotnet.NewAsync(new DotnetNewGlobalJsonOptions { SdkVersion = "8.0.100" });
await dotnet.NewAsync(new DotnetNewSolutionOptions { OutputName = "AppDemo" });
await dotnet.NewAsync(new DotnetNewConsoleOptions { OutputName = "AppDemo.Console" });
await dotnet.SlnAddAsync("AppDemo.Console/AppDemo.Console.csproj");
await git.StatusAsync();