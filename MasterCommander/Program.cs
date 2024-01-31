using MasterCommander.Integrations;
using Microsoft.Extensions.DependencyInjection;

WriteLine("MasterCommander");
WriteLine("--------------\n");

// get the required services
var services = MainExtensions.RegisterAppServices();
var git = services.GetRequiredService<IGitService>();
var dotnet = services.GetRequiredService<IDotnetService>();
var docker = services.GetRequiredService<IDockerService>();
var npm = services.GetRequiredService<INpmService>();

// initialize a new Git repository
await git.InitAsync();
await git.StatusAsync();
await dotnet.NewAsync("sln", "AppDemo", true);
