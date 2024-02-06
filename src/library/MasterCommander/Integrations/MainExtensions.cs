// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;

namespace MasterCommander.Integrations;

/// <summary>
/// Represents the main extensions for the application.
/// </summary>
public static class MainExtensions
{
    /// <summary>
    /// Provides extension methods for setting up application services.
    /// </summary>
    /// <returns>The project initialization service.</returns>
    public static IProjectInitializationService RegisterAppServices()
    {
        var services = new ServiceCollection();

        ConfigureDirectoryService(services);
        ConfigureConsole(services);
        ConfigureFactories(services);
        RegisterCoreServices(services);

        // Register higher-level services
        services.AddScoped<IProjectInitializationService, ProjectInitializationService>();

        var serviceProvider = services.BuildServiceProvider();
        return serviceProvider.GetRequiredService<IProjectInitializationService>();
    }

    private static void ConfigureDirectoryService(IServiceCollection services)
    {
        services.AddSingleton<IDirectoryService, DirectoryService>();
    }

    private static void ConfigureConsole(IServiceCollection services)
    {
        // Conditional registration based on the OS platform
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
    }

    private static void ConfigureFactories(IServiceCollection services)
    {
        services.AddScoped<IDockerCommandFactory, DockerCommandFactory>();
        services.AddScoped<IDotnetCommandFactory, DotnetCommandFactory>();
        services.AddScoped<IGitCommandFactory, GitCommandFactory>();
        services.AddScoped<INpmCommandFactory, NpmCommandFactory>();
    }

    private static void RegisterCoreServices(IServiceCollection services)
    {
        services.AddScoped<IDockerService, DockerService>();
        services.AddScoped<IDotnetService, DotnetService>();
        services.AddScoped<IGitService, GitService>();
        services.AddScoped<INpmService, NpmService>();
    }
}
