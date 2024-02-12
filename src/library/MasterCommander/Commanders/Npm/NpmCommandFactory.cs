// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Npm;

/// <summary>
/// Provides npm related operations.
/// </summary>
/// <param name="directoryService">The directory service to use for working directory operations.</param>
public class NpmCommandFactory(IDirectoryService directoryService)
    : CommandBuilder(directoryService), INpmCommandFactory
{
    /// <inheritdoc />
    public override string ExecutablePath => "npm";

    /// <inheritdoc />
    public Command CreateCommandInit()
    {
        string[] arguments = ["init"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandInstall()
    {
        string[] arguments = ["install"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandUpdate()
    {
        string[] arguments = ["update"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandStart()
    {
        string[] arguments = ["start"];
        return CreateCommand(arguments);
    }

    /// <inheritdoc />
    public Command CreateCommandRunScript(string scriptName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(scriptName);

        string[] arguments = ["run", scriptName];
        return CreateCommand(arguments);
    }
}
