// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.ConsoleEvents;

/// <summary>
/// Represents a console event that contains the standard output of a process.
/// </summary>
/// <param name="text">The text output to standard output.</param>
public class StandardOutputConsoleEvent(string text) : ConsoleEvent
{
    /// <summary>
    /// Gets the text output to standard output.
    /// </summary>
    public string Text { get; } = text;

    /// <summary>
    /// Returns a string representation of the standard output event.
    /// </summary>
    /// <returns>The standard output text.</returns>
    public override string ToString()
    {
        return Text;
    }
}
