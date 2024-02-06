// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Git;

/// <summary>
/// Defines the interface for creating git command instances.
/// </summary>
public interface IGitCommandFactory
{
    /// <summary>
    /// Creates a command for initializing a new git repository.
    /// </summary>
    /// <returns>A command to initialize a git repository.</returns>
    Command CreateCommandInit();

    /// <summary>
    /// Creates a command to check the status of the git repository.
    /// </summary>
    /// <returns>A command to display the status of the repository.</returns>
    Command CreateCommandStatus();

    /// <summary>
    /// Creates a command for cloning a remote repository into a local directory.
    /// </summary>
    /// <param name="repositoryUrl">The URL of the remote repository to clone.</param>
    /// <param name="localPath">The local directory path where the repository should be cloned.</param>
    /// <returns>A command to clone the repository.</returns>
    Command CreateCommandCloneRepository(string repositoryUrl, string localPath);

    /// <summary>
    /// Creates a command for committing changes to the repository with a specific message.
    /// </summary>
    /// <param name="message">The commit message to use.</param>
    /// <returns>A command to commit changes to the repository.</returns>
    Command CreateCommandCommit(string message);
}
