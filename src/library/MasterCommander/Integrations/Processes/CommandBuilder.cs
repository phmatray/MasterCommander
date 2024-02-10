// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Integrations.Processes;

/// <summary>
/// Provides a base for building commands to execute external processes, encapsulating common configuration aspects.
/// </summary>
/// <param name="directoryService">The directory service to use for working directory operations.</param>
public abstract class CommandBuilder(IDirectoryService directoryService)
{
    /// <summary>
    /// Gets the path to the executable that the command will run.
    /// </summary>
    protected abstract string ExecutablePath { get; }

    /// <summary>
    /// Creates a command with the specified arguments, configuring the executable path and working directory.
    /// </summary>
    /// <param name="arguments">The arguments to pass to the executable.</param>
    /// <returns>A configured command.</returns>
    protected virtual Command CreateCommand(IEnumerable<string> arguments)
    {
        var workingDirectory = GetWorkingDirectory();
        var command = Cli.Wrap(ExecutablePath)
            .WithArguments(arguments)
            .WithWorkingDirectory(workingDirectory);

        return ConfigureCommand(command);
    }

    /// <summary>
    /// Allows derived classes to further configure the command before execution.
    /// This method can be overridden to apply additional configurations like environment variables, timeout settings, etc.
    /// </summary>
    /// <param name="command">The command to configure.</param>
    /// <returns>The configured command.</returns>
    protected virtual Command ConfigureCommand(Command command)
    {
        // Allow derived classes to further configure the command
        return command;
    }

    /// <summary>
    /// Gets the working directory for the command execution.
    /// </summary>
    private string GetWorkingDirectory()
    {
        return directoryService.WorkingDirectory
               ?? directoryService.MasterCommanderDirectory;
    }
}
