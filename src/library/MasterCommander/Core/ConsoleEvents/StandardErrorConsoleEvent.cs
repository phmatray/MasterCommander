// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.ConsoleEvents;

/// <summary>
/// Represents a console event that contains the standard error output of a process.
/// </summary>
/// <param name="text">The text output to standard error.</param>
public class StandardErrorConsoleEvent(string text) : ConsoleEvent
{
    /// <summary>
    /// Gets the text output to standard error.
    /// </summary>
    public string Text { get; } = text;

    /// <summary>
    /// Returns a string representation of the standard error event.
    /// </summary>
    /// <returns>The standard error text.</returns>
    public override string ToString()
    {
        return Text;
    }
}
