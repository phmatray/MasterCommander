// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Git;

/// <summary>
/// Provides an interface for interacting with Git repositories asynchronously.
/// </summary>
public interface IGitService
{
    /// <summary>
    /// Initializes a new Git repository asynchronously.
    /// </summary>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous init operation.</returns>
    Task InitAsync(CancellationToken ct = default);

    /// <summary>
    /// Adds a file to the Git repository asynchronously.
    /// </summary>
    /// <param name="pathSpec">The path to the file to add.</param>
    /// <param name="options">Optional options for the add operation.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous add operation.</returns>
    Task AddAsync(
        string pathSpec,
        GitAddOptions? options = null,
        CancellationToken ct = default);

    /// <summary>
    /// Checks the status of the Git repository asynchronously.
    /// </summary>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous status operation, providing the status of the repository.</returns>
    Task StatusAsync(CancellationToken ct = default);

    /// <summary>
    /// Clones a remote Git repository into a local directory asynchronously.
    /// </summary>
    /// <param name="repositoryUrl">The URL of the remote repository to clone.</param>
    /// <param name="localPath">The local path where to clone the repository.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous clone operation.</returns>
    Task CloneRepositoryAsync(string repositoryUrl, string localPath, CancellationToken ct = default);

    /// <summary>
    /// Commits changes to the Git repository asynchronously with a specific message.
    /// </summary>
    /// <param name="message">The commit message.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous commit operation.</returns>
    Task CommitAsync(string message, CancellationToken ct = default);
}
