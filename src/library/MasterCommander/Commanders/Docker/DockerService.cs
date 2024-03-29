// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Docker;

/// <summary>
/// Provides Docker related operations.
/// </summary>
/// <param name="dockerCommandFactory">The factory for creating Docker commands.</param>
/// <param name="console">The console to use for output.</param>
public class DockerService(
    IDockerCommandFactory dockerCommandFactory, IConsole console)
    : CommandOutputHandler(console), IDockerService
{
    /// <inheritdoc />
    public async Task BuildAsync(string dockerfilePath, string tag, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.CreateCommandBuild(dockerfilePath, tag);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task RunAsync(string image, string? containerName = null, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.CreateCommandRun(image, containerName);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task StopAsync(string containerName, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.CreateCommandStop(containerName);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task RemoveContainerAsync(string containerName, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.CreateCommandRemoveContainer(containerName);
        await ListenCommandAsync(command, ct);
    }
}
