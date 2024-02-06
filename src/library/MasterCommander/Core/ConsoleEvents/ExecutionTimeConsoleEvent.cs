// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.ConsoleEvents;

/// <summary>
/// Represents a console event that indicates the execution time of a process.
/// </summary>
/// <param name="elapsedTime">The total elapsed time of the process execution.</param>
public class ExecutionTimeConsoleEvent(TimeSpan elapsedTime) : ConsoleEvent
{
    /// <summary>
    /// Gets or sets the total elapsed time of the process execution.
    /// </summary>
    public TimeSpan ElapsedTime { get; set; } = elapsedTime;

    /// <summary>
    /// Returns a string representation of the elapsed time event.
    /// </summary>
    /// <returns>A string indicating the elapsed time.</returns>
    public override string ToString()
    {
        return $"Elapsed time: {ElapsedTime}";
    }
}
