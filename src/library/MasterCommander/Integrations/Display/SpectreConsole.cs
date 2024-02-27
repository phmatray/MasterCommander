// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

using Spectre.Console;

namespace MasterCommander.Integrations.Display;

/// <summary>
/// Provides Spectre console output.
/// </summary>
public sealed class SpectreConsole : ConsoleBase
{
    /// <inheritdoc />
    public override void WriteLine(string? message = null)
    {
        try
        {
            AnsiConsole.MarkupLine(message ?? string.Empty);
        }
        catch (Exception)
        {
#pragma warning disable Spectre1000
            Console.WriteLine(message);
#pragma warning restore Spectre1000
        }
    }

    /// <inheritdoc />
    public override void WriteCommand(string command)
    {
        WriteLine($"🚀 [bold purple]Executing Command:[/] [underline]{command}[/]");
    }

    /// <inheritdoc />
    public override void WriteAction(string action, string message)
    {
        WriteLine($"🔧 [bold purple]{action}:[/] {message}");
    }

    /// <inheritdoc />
    public override void WriteStartupMessage()
    {
        AnsiConsole
            .Write(new Rule("[bold purple]MasterCommander[/]")
            .RuleStyle(Style.Parse("purple"))
            .Centered());

        AnsiConsole.WriteLine();
    }

    /// <inheritdoc />
    public override void WriteCompletionMessage()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"🔄 [dim]Starting Process: ID {started.ProcessId}...[/]");
    }

    /// <inheritdoc />
    public override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"[blue]=> {stdOutput.Text.Trim()}[/]");
        }
    }

    /// <inheritdoc />
    public override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"[red]=> Error: {stdError.Text.Trim()}[/]");
        }
    }

    /// <inheritdoc />
    public override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        var statusMessage = exited.ExitCode == 0
            ? "[green]✅  Process successfully completed.[/]"
            : $"[red]❌  Process completed with exit code {exited.ExitCode}.[/]";

        WriteLine(statusMessage);
    }

    /// <inheritdoc />
    public override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"⏱️ [dim]Elapsed Time: {elapsed.ElapsedTime}[/]");
        AnsiConsole.WriteLine(); // Adds a spacer line for better separation
    }
}
