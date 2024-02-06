// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Docker;

/// <summary>
/// Defines the interface for creating Docker command instances.
/// </summary>
/// <param name="workingDirectory">The working directory for the command.</param>
/// <param name="executablePath">The path to the docker executable.</param>
public class DockerCommandFactory(
    string workingDirectory = ".",
    string executablePath = "docker")
    : CommandBuilder(workingDirectory, executablePath), IDockerCommandFactory
{
    /// <inheritdoc />
    public Command CreateCommandBuild(string dockerfilePath, string tag)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(dockerfilePath);
        ArgumentException.ThrowIfNullOrWhiteSpace(tag);

        string[] arguments = ["build", "-f", dockerfilePath, "-t", tag, "."];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandRun(string image, string? containerName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(image);

        string[] arguments = string.IsNullOrWhiteSpace(containerName)
            ? ["run", image]
            : ["run", "--name", containerName, image];

        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandStop(string containerName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(containerName);

        string[] arguments = ["stop", containerName];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandRemoveContainer(string containerName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(containerName);

        string[] arguments = ["rm", containerName];
        return CreateCommand(arguments);
    }

    // Additional Docker commands can be implemented here...
}
