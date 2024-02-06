// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
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
    /// Writes a startup message to the console. This is intended for initial console output upon application start.
    /// </summary>
    void WriteStartupMessage();

    /// <summary>
    /// Writes a console event to the console. This method is designed to handle and display various types of console events.
    /// </summary>
    /// <param name="consoleEvent">The console event to write.</param>
    void WriteConsoleEvent(ConsoleEvent consoleEvent);
}
