// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.ConsoleEvents;

/// <summary>
/// Represents a console event that indicates the start of a process, including its process ID.
/// </summary>
/// <param name="processId">The ID of the started process.</param>
public class StartedConsoleEvent(int processId) : ConsoleEvent
{
    /// <summary>
    /// Gets the process ID of the started process.
    /// </summary>
    public int ProcessId { get; } = processId;

    /// <summary>
    /// Returns a string representation of the start event.
    /// </summary>
    /// <returns>A string indicating the process ID.</returns>
    public override string ToString()
    {
        return $"Process ID: {ProcessId}";
    }
}
