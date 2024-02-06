// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Git;

/// <summary>
/// Provides an implementation for interacting with Git repositories asynchronously.
/// </summary>
/// <param name="gitCommandFactory">The factory for creating git command instances.</param>
/// <param name="console">The console to use for output.</param>
public class GitService(
    IGitCommandFactory gitCommandFactory,
    IConsole console)
    : CommandOutputHandler(console), IGitService
{
    /// <inheritdoc />
    public async Task InitAsync(CancellationToken ct = default)
    {
        var command = gitCommandFactory.Init();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task StatusAsync(CancellationToken ct = default)
    {
        var command = gitCommandFactory.Status();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task CloneRepositoryAsync(string repositoryUrl, string localPath, CancellationToken ct = default)
    {
        var command = gitCommandFactory.CloneRepository(repositoryUrl, localPath);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task CommitAsync(string message, CancellationToken ct = default)
    {
        var command = gitCommandFactory.Commit(message);
        await ListenCommandAsync(command, ct);
    }
}
