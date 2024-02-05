namespace MasterCommander.Integrations.Display;

public sealed class StandardConsole
    : ConsoleBase, IConsole
{
    public void WriteLine(string? message = null)
    {
        Console.WriteLine(message ?? string.Empty);
    }

    public void WriteCommand(string command)
    {
        WriteLine($"Executing Command: {command}");
    }

    public void WriteStartupMessage()
    {
        WriteLine("\n-----------------");
        WriteLine(" MasterCommander");
        WriteLine("-----------------\n");
    }

    protected override void WriteStartedConsoleEvent(StartedConsoleEvent started)
    {
        WriteLine($"Starting Process: ID {started.ProcessId}...");
    }

    protected override void WriteStandardOutputConsoleEvent(StandardOutputConsoleEvent stdOutput)
    {
        if (!string.IsNullOrWhiteSpace(stdOutput.Text))
        {
            WriteLine($"=> {stdOutput.Text.Trim()}");
        }
    }

    protected override void WriteStandardErrorConsoleEvent(StandardErrorConsoleEvent stdError)
    {
        if (!string.IsNullOrWhiteSpace(stdError.Text))
        {
            WriteLine($"Error: {stdError.Text.Trim()}");
        }
    }

    protected override void WriteExitedConsoleEvent(ExitedConsoleEvent exited)
    {
        var statusMessage = exited.ExitCode == 0
            ? "Process successfully completed."
            : $"Process completed with exit code {exited.ExitCode}.";
        WriteLine(statusMessage);
    }

    protected override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"Elapsed time: {elapsed.ElapsedTime}");
        WriteLine();
    }
}