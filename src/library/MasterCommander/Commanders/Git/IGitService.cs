// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
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
