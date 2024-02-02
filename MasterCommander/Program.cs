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
await dotnet.NewAsync("gitignore");
await dotnet.NewAsync("editorconfig");
await dotnet.NewAsync("globaljson");
await dotnet.NewAsync("sln", "AppDemo", true);
await dotnet.NewAsync("console", "AppDemo.Console");
await dotnet.SlnAddAsync("AppDemo.Console/AppDemo.Console.csproj");
await git.StatusAsync();