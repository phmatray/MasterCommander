namespace MasterCommander.Integrations.Display;

public class StandardConsole
    : ConsoleBase, IConsole
{
    public void WriteLine(string? message = null)
    {
        if (message is not null)
        {
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine();
        }
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
        WriteLine(exited.ExitCode == 0
            ? "Process successfully completed."
            : $"Process completed with exit code {exited.ExitCode}.");
    }

    protected override void WriteElapsedConsoleEvent(ExecutionTimeConsoleEvent elapsed)
    {
        WriteLine($"Elapsed time: {elapsed.ElapsedTime}");
        WriteLine();
    }
}