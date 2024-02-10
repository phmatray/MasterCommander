// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Display;

/// <summary>
/// Defines an interface for console operations, allowing for writing lines, commands, startup messages, and console events.
/// </summary>
public interface IConsole
{
    /// <summary>
    /// Writes a line to the console. If the message is null, writes an empty line.
    /// </summary>
    /// <param name="message">The message to write, or null to write an empty line.</param>
    void WriteLine(string? message = null);

    /// <summary>
    /// Writes a command text to the console.
    /// </summary>
    /// <param name="command">The command text to write.</param>
    void WriteCommand(string command);

    /// <summary>
    /// Writes an action message to the console.
    /// </summary>
    /// <param name="action">The action to write.</param>
    /// <param name="message">The message to write.</param>
    void WriteAction(string action, string message);

    /// <summary>
    /// Writes a startup message to the console. This is intended for initial console output upon application start.
    /// </summary>
    void WriteStartupMessage();

    /// <summary>
    /// Writes a console event to the console. This method is designed to handle and display various types of console events.
    /// </summary>
    /// <param name="consoleEvent">The console event to write.</param>
    void WriteConsoleEvent(ConsoleEvent consoleEvent);

    /// <summary>
    /// Writes a completion message to the console. This is intended for final console output upon application completion.
    /// </summary>
    void WriteCompletionMessage();

    /// <summary>
    /// Writes a started console event to the output.
    /// </summary>
    /// <param name="started">The started console event to write.</param>
    void WriteStartedConsoleEvent(StartedConsoleEvent started);

    /// <summary>
    /// Writes a standard output console event to the output.
    /// </summary>
    /// <param name="stdOutput">The standard output console event to write.</param>
    void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput);

    /// <summary>
    /// Writes a standard error console event to the output.
    /// </summary>
    /// <param name="stdError">The standard error console event to write.</param>
    void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError);

    /// <summary>
    /// Writes an exited console event to the output.
    /// </summary>
    /// <param name="exited">The exited console event to write.</param>
    void WriteExitedConsoleEvent(ExitedConsoleEvent exited);

    /// <summary>
    /// Writes an execution time console event to the output.
    /// </summary>
    /// <param name="elapsed">The execution time console event to write.</param>
    void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed);
}
