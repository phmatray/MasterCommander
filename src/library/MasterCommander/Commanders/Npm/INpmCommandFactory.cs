// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Npm;

/// <summary>
/// Defines the interface for creating npm command instances.
/// </summary>
public interface INpmCommandFactory
{
    /// <summary>
    /// Creates a command for initializing a new npm project.
    /// </summary>
    /// <returns>A command to initialize a new npm project.</returns>
    Command Init();

    /// <summary>
    /// Creates a command for installing npm packages in the project.
    /// </summary>
    /// <returns>A command to install npm packages.</returns>
    Command Install();

    /// <summary>
    /// Creates a command for updating npm packages in the project.
    /// </summary>
    /// <returns>A command to update npm packages.</returns>
    Command Update();

    /// <summary>
    /// Creates a command to start the npm project.
    /// </summary>
    /// <returns>A command to start the project.</returns>
    Command Start();

    /// <summary>
    /// Creates a command to run a specific npm script defined in the project's package.json.
    /// </summary>
    /// <param name="scriptName">The name of the script to run.</param>
    /// <returns>A command to run the specified npm script.</returns>
    Command RunScript(string scriptName);
}
