// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace MasterCommander.Core.Display;

/// <summary>
/// Provides factory methods for creating various types of console events.
/// </summary>
public static class ConsoleEventFactory
{
    /// <summary>
    /// Creates a console event based on the elapsed time from a stopwatch.
    /// </summary>
    /// <param name="stopWatch">The stopwatch used to measure the elapsed time.</param>
    /// <returns>A console event representing the execution time.</returns>
    public static ConsoleEvent CreateFrom(Stopwatch stopWatch)
    {
        return new ExecutionTimeConsoleEvent(stopWatch.Elapsed);
    }

    /// <summary>
    /// Creates a specific type of console event based on the given command event.
    /// </summary>
    /// <param name="cmdEvent">The command event to create a console event from.</param>
    /// <returns>A console event corresponding to the specified command event.</returns>
    /// <exception cref="ArgumentException">Thrown when an unknown command event type is provided.</exception>
    public static ConsoleEvent CreateFrom(CommandEvent cmdEvent)
    {
        return cmdEvent switch
        {
            StartedCommandEvent started => CreateStartedEvent(started.ProcessId),
            StandardOutputCommandEvent stdOut => CreateStandardOutputEvent(stdOut.Text),
            StandardErrorCommandEvent stdErr => CreateStandardErrorEvent(stdErr.Text),
            ExitedCommandEvent exited => CreateExitedEvent(exited.ExitCode),
            _ => throw new ArgumentException($"Unknown command event type: {cmdEvent.GetType().Name}")
        };
    }

    /// <summary>
    /// Creates a console event indicating a process has started.
    /// </summary>
    /// <param name="processId">The ID of the started process.</param>
    /// <returns>A console event for a started process.</returns>
    private static StartedConsoleEvent CreateStartedEvent(int processId)
    {
        return new StartedConsoleEvent(processId);
    }

    /// <summary>
    /// Creates a console event for standard output messages.
    /// </summary>
    /// <param name="message">The message from standard output.</param>
    /// <returns>A console event containing the standard output message.</returns>
    private static StandardOutputConsoleEvent CreateStandardOutputEvent(string message)
    {
        return new StandardOutputConsoleEvent(message);
    }

    /// <summary>
    /// Creates a console event for standard error messages.
    /// </summary>
    /// <param name="message">The message from standard error.</param>
    /// <returns>A console event containing the standard error message.</returns>
    private static StandardErrorConsoleEvent CreateStandardErrorEvent(string message)
    {
        return new StandardErrorConsoleEvent(message);
    }

    /// <summary>
    /// Creates a console event indicating a process has exited.
    /// </summary>
    /// <param name="exitCode">The exit code of the process.</param>
    /// <returns>A console event for an exited process.</returns>
    private static ExitedConsoleEvent CreateExitedEvent(int exitCode)
    {
        return new ExitedConsoleEvent(exitCode);
    }
}
