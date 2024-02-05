using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;

namespace MasterCommander.Integrations;

public static class MainExtensions
{
    private const string AppName = "MasterCommander";
    
    public static IProjectInitializationService RegisterAppServices()
    {
        var services = new ServiceCollection();
        var directoryService = new DirectoryService();
        
        // get the working directory
        var homeDirectory = directoryService.GetHomeDirectory();
        var workingDirectory = directoryService.CreateNewDirectory(homeDirectory, AppName, true);
        
        // outputs
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            // on OSX, use Spectre.Console for better rendering
            services.AddScoped<IConsole, SpectreConsole>();
        }
        else
        {
            // on Windows, use StandardConsole
            services.AddScoped<IConsole, StandardConsole>();
        }
        
        // factories
        services.AddScoped<IDockerCommandFactory, DockerCommandFactory>(
            _ => new DockerCommandFactory(workingDirectory));
        
        services.AddScoped<IDotnetCommandFactory, DotnetCommandFactory>(
            _ => new DotnetCommandFactory(workingDirectory));
        
        services.AddScoped<IGitCommandFactory, GitCommandFactory>(
            _ => new GitCommandFactory(workingDirectory));
        
        services.AddScoped<INpmCommandFactory, NpmCommandFactory>(
            _ => new NpmCommandFactory(workingDirectory));
        
        // core services
        services.AddScoped<IDockerService, DockerService>();
        services.AddScoped<IDotnetService, DotnetService>();
        services.AddScoped<IGitService, GitService>();
        services.AddScoped<INpmService, NpmService>();
        
        // higher level services
        services.AddScoped<IProjectInitializationService, ProjectInitializationService>();

        ServiceProvider serviceProvider = services.BuildServiceProvider();
        var projectInitializationService = serviceProvider.GetRequiredService<IProjectInitializationService>();
        
        return projectInitializationService;
    }
}
