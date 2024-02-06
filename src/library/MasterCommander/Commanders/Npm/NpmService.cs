// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Npm;

/// <summary>
/// Provides npm related operations.
/// </summary>
/// <param name="npmCommandFactory">The factory for creating npm commands.</param>
/// <param name="console">The console to use for output.</param>
public class NpmService(
    INpmCommandFactory npmCommandFactory, IConsole console)
    : CommandOutputHandler(console), INpmService
{
    /// <inheritdoc />
    public async Task InitAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Init();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task InstallAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Install();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task UpdateAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Update();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task StartAsync(CancellationToken ct = default)
    {
        var command = npmCommandFactory.Start();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc />
    public async Task RunScriptAsync(string scriptName, CancellationToken ct = default)
    {
        var command = npmCommandFactory.RunScript(scriptName);
        await ListenCommandAsync(command, ct);
    }
}
