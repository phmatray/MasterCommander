// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Integrations.Display;

/// <summary>
/// Provides standard console output.
/// </summary>
public sealed class StandardConsole : ConsoleBase
{
    /// <inheritdoc />
    public override void WriteLine(string? message = null)
    {
        Console.WriteLine(message ?? string.Empty);
    }

    /// <inheritdoc />
    public override void WriteCommand(string command)
    {
        WriteLine($"Executing Command: {command}");
    }

    /// <inheritdoc />
    public override void WriteAction(string action, string message)
    {
        WriteLine($"{action}: {message}");
    }

    /// <inheritdoc />
    public override void WriteStartupMessage()
    {
        WriteLine("\n-----------------");
        WriteLine(" MasterCommander");
        WriteLine("-----------------\n");
    }

    /// <inheritdoc />
    public override void WriteCompletionMessage()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"Starting Process: ID {started.ProcessId}...");
    }

    /// <inheritdoc />
    public override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"=> {stdOutput.Text.Trim()}");
        }
    }

    /// <inheritdoc />
    public override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"Error: {stdError.Text.Trim()}");
        }
    }

    /// <inheritdoc />
    public override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        var statusMessage = exited.ExitCode == 0
            ? "Process successfully completed."
            : $"Process completed with exit code {exited.ExitCode}.";

        WriteLine(statusMessage);
    }

    /// <inheritdoc />
    public override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"Elapsed time: {elapsed.ElapsedTime}");
        WriteLine();
    }
}
