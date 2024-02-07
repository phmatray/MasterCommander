// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Integrations.Display;

/// <summary>
/// Provides standard console output.
/// </summary>
public sealed class StandardConsole
    : ConsoleBase, IConsole
{
    /// <inheritdoc />
    public void WriteLine(string? message = null)
    {
        Console.WriteLine(message ?? string.Empty);
    }

    /// <inheritdoc />
    public void WriteCommand(string command)
    {
        WriteLine($"Executing Command: {command}");
    }

    /// <inheritdoc />
    public void WriteStartupMessage()
    {
        WriteLine("\n-----------------");
        WriteLine(" MasterCommander");
        WriteLine("-----------------\n");
    }

    /// <inheritdoc />
    public void WriteCompletionMessage()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    protected override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"Starting Process: ID {started.ProcessId}...");
    }

    /// <inheritdoc />
    protected override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"=> {stdOutput.Text.Trim()}");
        }
    }

    /// <inheritdoc />
    protected override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"Error: {stdError.Text.Trim()}");
        }
    }

    /// <inheritdoc />
    protected override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        var statusMessage = exited.ExitCode == 0
            ? "Process successfully completed."
            : $"Process completed with exit code {exited.ExitCode}.";

        WriteLine(statusMessage);
    }

    /// <inheritdoc />
    protected override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"Elapsed time: {elapsed.ElapsedTime}");
        WriteLine();
    }
}
