using MasterCommander;
using Microsoft.Extensions.DependencyInjection;

WriteLine("MasterCommander");
WriteLine("--------------\n");

// get home directory
string homeDirectory = 
    GetEnvironmentVariable("HOME")
    ?? GetEnvironmentVariable("USERPROFILE")
    ?? throw new Exception("Could not find home directory");

// create a new directory
string workingDirectory = Path.Combine(homeDirectory, "MasterCommander");
Directory.CreateDirectory(workingDirectory);

// get the required services
ServiceProvider services = MainExtensions.RegisterAppServices();
var git = services.GetRequiredService<IGitService>();
var dotnet = services.GetRequiredService<IDotnetService>();
var docker = services.GetRequiredService<IDockerService>();
var npm = services.GetRequiredService<INpmService>();

// initialize a new Git repository
await git.InitAsync();
await git.StatusAsync();
await dotnet.NewAsync("sln", "AppDemo");
await dotnet.NewAsync("sln", "AppDaemon");
await npm.InitAsync();
await docker.RunAsync("run", "hello-world");
