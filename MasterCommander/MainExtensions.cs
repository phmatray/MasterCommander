using Microsoft.Extensions.DependencyInjection;

namespace MasterCommander;

public static class MainExtensions
{
    public static ServiceProvider RegisterAppServices()
    {
        var serviceCollection = new ServiceCollection();
        
        serviceCollection.AddScoped<IConsole, StandardConsole>();
        
        // docker
        serviceCollection.AddScoped<IDockerCommandFactory, DockerCommandFactory>(_ => new DockerCommandFactory());
        serviceCollection.AddScoped<IDockerService, DockerService>();
        
        // dotnet
        serviceCollection.AddScoped<IDotnetCommandFactory, DotnetCommandFactory>(_ => new DotnetCommandFactory());
        serviceCollection.AddScoped<IDotnetService, DotnetService>();
        
        // git
        serviceCollection.AddScoped<IGitCommandFactory, GitCommandFactory>(_ => new GitCommandFactory());
        serviceCollection.AddScoped<IGitService, GitService>();
        
        // npm
        serviceCollection.AddScoped<INpmCommandFactory, NpmCommandFactory>(_ => new NpmCommandFactory());
        serviceCollection.AddScoped<INpmService, NpmService>();

        return serviceCollection.BuildServiceProvider();
    }
}
