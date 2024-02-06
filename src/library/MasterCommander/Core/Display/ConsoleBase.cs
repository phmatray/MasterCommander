// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Display;

/// <summary>
/// Serves as the base class for console output handling, providing a mechanism to write different types of console events.
/// </summary>
public abstract class ConsoleBase
{
    /// <summary>
    /// Writes the specified console event to the console. The specific type of event determines the method called to handle the output.
    /// </summary>
    /// <param name="consoleEvent">The console event to write.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the console event type is not recognized.</exception>
    public void WriteConsoleEvent(ConsoleEvent consoleEvent)
    {
        switch (consoleEvent)
        {
            case StartedConsoleEvent started:
                WriteStartedConsoleEvent(started);
                break;
            case StandardOutputConsoleEvent stdOutput:
                WriteStandardOutputConsoleEvent(stdOutput);
                break;
            case StandardErrorConsoleEvent stdError:
                WriteStandardErrorConsoleEvent(stdError);
                break;
            case ExitedConsoleEvent exited:
                WriteExitedConsoleEvent(exited);
                break;
            case ExecutionTimeConsoleEvent elapsed:
                WriteElapsedConsoleEvent(elapsed);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(consoleEvent));
        }
    }

    /// <summary>
    /// Writes a started console event to the output.
    /// </summary>
    /// <param name="started">The started console event to write.</param>
    protected abstract void WriteStartedConsoleEvent(StartedConsoleEvent started);

    /// <summary>
    /// Writes a standard output console event to the output.
    /// </summary>
    /// <param name="stdOutput">The standard output console event to write.</param>
    protected abstract void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput);

    /// <summary>
    /// Writes a standard error console event to the output.
    /// </summary>
    /// <param name="stdError">The standard error console event to write.</param>
    protected abstract void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError);

    /// <summary>
    /// Writes an exited console event to the output.
    /// </summary>
    /// <param name="exited">The exited console event to write.</param>
    protected abstract void WriteExitedConsoleEvent(ExitedConsoleEvent exited);

    /// <summary>
    /// Writes an execution time console event to the output.
    /// </summary>
    /// <param name="elapsed">The execution time console event to write.</param>
    protected abstract void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed);
}
