// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides .NET related operations.
/// </summary>
/// <param name="dotnetCommandFactory">The factory for creating dotnet command instances.</param>
/// <param name="console">The console to use for output.</param>
public class DotnetService(
    IDotnetCommandFactory dotnetCommandFactory,
    IConsole console)
    : CommandOutputHandler(console), IDotnetService
{
    /// <inheritdoc/>
    public async Task NewAsync(
        DotnetNewOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetNewOptions("console");
        var command = dotnetCommandFactory.CreateCommandNew(options);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task BuildAsync(
        DotnetBuildOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetBuildOptions();
        var command = dotnetCommandFactory.CreateCommandBuild(options);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task RunAsync(
        DotnetRunOptions? options = null,
        CancellationToken ct = default)
    {
        options ??= new DotnetRunOptions();
        var command = dotnetCommandFactory.CreateCommandRun(options);
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task TestAsync(CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.CreateCommandTest();
        await ListenCommandAsync(command, ct);
    }

    /// <inheritdoc/>
    public async Task SlnAddAsync(string csproj, CancellationToken ct = default)
    {
        var command = dotnetCommandFactory.CreateCommandSlnAdd(csproj);
        await ListenCommandAsync(command, ct);
    }
}
