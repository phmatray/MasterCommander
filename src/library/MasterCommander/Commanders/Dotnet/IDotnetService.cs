// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet;

/// <summary>
/// Provides an interface for .NET related operations.
/// </summary>
public interface IDotnetService
{
    /// <summary>
    /// Creates a new .NET project with the specified template and outputName.
    /// </summary>
    /// <param name="options">The options to use.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task NewAsync(
        DotnetNewOptions? options = null,
        CancellationToken ct = default);

    /// <summary>
    /// Builds the .NET project.
    /// </summary>
    /// <param name="options">The options to use.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task BuildAsync(
        DotnetBuildOptions? options = null,
        CancellationToken ct = default);

    /// <summary>
    /// Runs the .NET project.
    /// </summary>
    /// <param name="options">The options to use.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task RunAsync(
        DotnetRunOptions? options = null,
        CancellationToken ct = default);

    /// <summary>
    /// Runs the tests in the .NET project.
    /// </summary>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task TestAsync(CancellationToken ct = default);

    /// <summary>
    /// Adds the specified .NET project to the solution.
    /// </summary>
    /// <param name="csproj">The path to the .NET project.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task SlnAddAsync(string csproj, CancellationToken ct = default);
}
