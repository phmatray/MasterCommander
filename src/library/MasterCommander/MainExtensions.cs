// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;

namespace MasterCommander;

/// <summary>
/// Represents the main extensions for the application.
/// </summary>
public static class MainExtensions
{
    /// <summary>
    /// Adds the MasterCommander services to the specified <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddMasterCommanderServices(this IServiceCollection services)
    {
        ConfigureDirectoryService(services);
        ConfigureConsole(services);
        ConfigureFactories(services);
        RegisterCoreServices(services);

        // Register higher-level services
        services.AddScoped<IProjectInitializationService, ProjectInitializationService>();

        return services;
    }

    /// <summary>
    /// Provides extension methods for setting up application services.
    /// </summary>
    /// <returns>The project initialization service.</returns>
    public static IServiceCollection CreateMasterCommanderServices()
    {
        var services = new ServiceCollection();
        return services.AddMasterCommanderServices();
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
