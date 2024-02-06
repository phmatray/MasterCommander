// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Npm;

/// <summary>
/// Provides an interface for interacting with npm (Node Package Manager) operations asynchronously.
/// </summary>
public interface INpmService
{
    /// <summary>
    /// Initializes a new npm project asynchronously.
    /// </summary>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of initializing a new npm project.</returns>
    Task InitAsync(CancellationToken ct = default);

    /// <summary>
    /// Installs npm packages for the project asynchronously.
    /// </summary>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of installing npm packages.</returns>
    Task InstallAsync(CancellationToken ct = default);

    /// <summary>
    /// Updates npm packages for the project asynchronously.
    /// </summary>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of updating npm packages.</returns>
    Task UpdateAsync(CancellationToken ct = default);

    /// <summary>
    /// Starts the npm project asynchronously.
    /// </summary>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of starting the npm project.</returns>
    Task StartAsync(CancellationToken ct = default);

    /// <summary>
    /// Runs a specified script defined in the project's package.json file asynchronously.
    /// </summary>
    /// <param name="scriptName">The name of the script to run.</param>
    /// <param name="ct">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation of running the specified npm script.</returns>
    Task RunScriptAsync(string scriptName, CancellationToken ct = default);
}
