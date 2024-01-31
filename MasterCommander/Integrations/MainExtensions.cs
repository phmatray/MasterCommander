using Microsoft.Extensions.DependencyInjection;
using static MasterCommander.Integrations.DirectoryHelper;

namespace MasterCommander.Integrations;

public static class MainExtensions
{
    private const string AppName = "MasterCommander";
    
    public static ServiceProvider RegisterAppServices(bool useColor = true)
    {
        var services = new ServiceCollection();
        
        // get the working directory
        var homeDirectory = GetHomeDirectory();
        var workingDirectory = CreateNewDirectory(homeDirectory, AppName, true);
        
        // outputs
        if (useColor)
        {
            services.AddScoped<IConsole, SpectreConsole>();
        }
        else
        {
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
        
        // services
        services.AddScoped<IDockerService, DockerService>();
        services.AddScoped<IDotnetService, DotnetService>();
        services.AddScoped<IGitService, GitService>();
        services.AddScoped<INpmService, NpmService>();

        return services.BuildServiceProvider();
    }
}
