// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.ConsoleEvents;

/// <summary>
/// Represents a console event that indicates the exit code of a process.
/// </summary>
/// <param name="exitCode">The exit code of the process.</param>
public class ExitedConsoleEvent(int exitCode) : ConsoleEvent
{
    /// <summary>
    /// Gets the exit code of the process.
    /// </summary>
    public int ExitCode { get; } = exitCode;

    /// <summary>
    /// Returns a string representation of the exit code event.
    /// </summary>
    /// <returns>A string indicating the exit code.</returns>
    public override string ToString()
    {
        return $"Exit code: {ExitCode}";
    }
}
