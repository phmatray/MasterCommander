using Spectre.Console;

namespace MasterCommander.Integrations.Display;

public sealed class SpectreConsole
    : ConsoleBase, IConsole
{
    public void WriteLine(string? message = null)
    {
        AnsiConsole.MarkupLine(message ?? string.Empty);
    }

    public void WriteCommand(string command)
    {
        WriteLine($"🚀 [bold purple]Executing Command:[/] [underline]{command}[/]");
    }

    public void WriteStartupMessage()
    {
        AnsiConsole
            .Write(new Rule("[bold purple]MasterCommander[/]")
            .RuleStyle(Style.Parse("purple"))
            .Centered());
        
        AnsiConsole.WriteLine();
    }

    protected override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"🔄 [dim]Starting Process: ID {started.ProcessId}...[/]");
    }

    protected override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"[blue]=> {stdOutput.Text.Trim()}[/]");
        }
    }

    protected override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"[red]=> Error: {stdError.Text.Trim()}[/]");
        }
    }

    protected override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        var statusMessage = exited.ExitCode == 0
            ? "[green]✅  Process successfully completed.[/]"
            : $"[red]❌  Process completed with exit code {exited.ExitCode}.[/]";

        WriteLine(statusMessage);
    }

    protected override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"⏱️ [dim]Elapsed Time: {elapsed.ElapsedTime}[/]");
        AnsiConsole.WriteLine(); // Adds a spacer line for better separation
    }
}