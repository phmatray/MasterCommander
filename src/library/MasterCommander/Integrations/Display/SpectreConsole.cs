// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Spectre.Console;

namespace MasterCommander.Integrations.Display;

/// <summary>
/// Provides Spectre console output.
/// </summary>
public sealed class SpectreConsole
    : ConsoleBase, IConsole
{
    /// <inheritdoc />
    public void WriteLine(string? message = null)
    {
        AnsiConsole.MarkupLine(message ?? string.Empty);
    }

    /// <inheritdoc />
    public void WriteCommand(string command)
    {
        WriteLine($"🚀 [bold purple]Executing Command:[/] [underline]{command}[/]");
    }

    /// <inheritdoc />
    public void WriteStartupMessage()
    {
        AnsiConsole
            .Write(new Rule("[bold purple]MasterCommander[/]")
            .RuleStyle(Style.Parse("purple"))
            .Centered());

        AnsiConsole.WriteLine();
    }

    /// <inheritdoc />
    protected override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"🔄 [dim]Starting Process: ID {started.ProcessId}...[/]");
    }

    /// <inheritdoc />
    protected override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"[blue]=> {stdOutput.Text.Trim()}[/]");
        }
    }

    /// <inheritdoc />
    protected override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"[red]=> Error: {stdError.Text.Trim()}[/]");
        }
    }

    /// <inheritdoc />
    protected override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        var statusMessage = exited.ExitCode == 0
            ? "[green]✅  Process successfully completed.[/]"
            : $"[red]❌  Process completed with exit code {exited.ExitCode}.[/]";

        WriteLine(statusMessage);
    }

    /// <inheritdoc />
    protected override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"⏱️ [dim]Elapsed Time: {elapsed.ElapsedTime}[/]");
        AnsiConsole.WriteLine(); // Adds a spacer line for better separation
    }
}
