// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Display;

/// <summary>
/// Serves as the base class for console output handling, providing a mechanism to write different types of console events.
/// </summary>
public abstract class ConsoleBase : IConsole
{
    /// <inheritdoc />
    public abstract void WriteLine(string? message = null);

    /// <inheritdoc />
    public abstract void WriteCommand(string command);

    /// <inheritdoc />
    public abstract void WriteAction(string action, string message);

    /// <inheritdoc />
    public abstract void WriteStartupMessage();

    /// <inheritdoc />
    public abstract void WriteCompletionMessage();

    /// <inheritdoc />
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

    /// <inheritdoc />
    public abstract void WriteStartedConsoleEvent(StartedConsoleEvent started);

    /// <inheritdoc />
    public abstract void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput);

    /// <inheritdoc />
    public abstract void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError);

    /// <inheritdoc />
    public abstract void WriteExitedConsoleEvent(ExitedConsoleEvent exited);

    /// <inheritdoc />
    public abstract void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed);
}
