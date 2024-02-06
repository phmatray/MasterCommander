// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Git;

/// <summary>
/// A factory for creating git command instances.
/// </summary>
/// <param name="workingDirectory">The working directory for the command.</param>
/// <param name="executablePath">The path to the git executable.</param>
public class GitCommandFactory(
    string workingDirectory = ".",
    string executablePath = "git")
    : CommandBuilder(workingDirectory, executablePath), IGitCommandFactory
{
    /// <inheritdoc />
    public Command CreateCommandInit()
    {
        string[] arguments = ["init"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandStatus()
    {
        string[] arguments = ["status"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandCloneRepository(string repositoryUrl, string localPath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(repositoryUrl);
        ArgumentException.ThrowIfNullOrWhiteSpace(localPath);

        string[] arguments = ["clone", repositoryUrl, localPath];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandCommit(string message)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);

        string[] arguments = ["commit", "-m", message];
        return CreateCommand(arguments);
    }
}
