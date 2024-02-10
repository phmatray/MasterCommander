// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Docker;

/// <summary>
/// Defines the interface for creating Docker command instances.
/// </summary>
public interface IDockerCommandFactory
{
    /// <summary>
    /// Creates a command to build a Docker image from a Dockerfile.
    /// </summary>
    /// <param name="dockerfilePath">The path to the Dockerfile.</param>
    /// <param name="tag">The tag to assign to the built image.</param>
    /// <returns>A command to build a Docker image.</returns>
    Command CreateCommandBuild(string dockerfilePath, string tag);

    /// <summary>
    /// Creates a command to run a Docker container from an image.
    /// </summary>
    /// <param name="image">The Docker image to run.</param>
    /// <param name="containerName">Optional name for the container.</param>
    /// <returns>A command to run a Docker container.</returns>
    Command CreateCommandRun(string image, string? containerName = null);

    /// <summary>
    /// Creates a command to stop a running Docker container.
    /// </summary>
    /// <param name="containerName">The name of the container to stop.</param>
    /// <returns>A command to stop a Docker container.</returns>
    Command CreateCommandStop(string containerName);

    /// <summary>
    /// Creates a command to remove a Docker container.
    /// </summary>
    /// <param name="containerName">The name of the container to remove.</param>
    /// <returns>A command to remove a Docker container.</returns>
    Command CreateCommandRemoveContainer(string containerName);
}
