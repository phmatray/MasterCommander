// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Npm;

/// <summary>
/// Provides npm related operations.
/// </summary>
/// <param name="workingDirectory">The working directory where the npm commands will be executed.</param>
/// <param name="executablePath">The path to the npm executable.</param>
public class NpmCommandFactory(
    string workingDirectory = ".",
    string executablePath = "npm")
    : CommandBuilder(workingDirectory, executablePath), INpmCommandFactory
{
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
