// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Docker;

/// <summary>
/// Provides an interface for managing Docker operations asynchronously.
/// </summary>
public interface IDockerService
{
    /// <summary>
    /// Builds a Docker image from a Dockerfile asynchronously.
    /// </summary>
    /// <param name="dockerfilePath">The path to the Dockerfile.</param>
    /// <param name="tag">The tag to assign to the built image.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of building a Docker image.</returns>
    Task BuildAsync(string dockerfilePath, string tag, CancellationToken ct = default);

    /// <summary>
    /// Runs a Docker container from an image asynchronously.
    /// </summary>
    /// <param name="image">The Docker image to run.</param>
    /// <param name="containerName">Optional name for the container.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of running a Docker container.</returns>
    Task RunAsync(string image, string? containerName = null, CancellationToken ct = default);

    /// <summary>
    /// Stops a running Docker container asynchronously.
    /// </summary>
    /// <param name="containerName">The name of the container to stop.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of stopping a Docker container.</returns>
    Task StopAsync(string containerName, CancellationToken ct = default);

    /// <summary>
    /// Removes a Docker container asynchronously.
    /// </summary>
    /// <param name="containerName">The name of the container to remove.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of removing a Docker container.</returns>
    Task RemoveContainerAsync(string containerName, CancellationToken ct = default);
}
