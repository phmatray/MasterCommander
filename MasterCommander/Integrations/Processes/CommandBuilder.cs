namespace MasterCommander.Integrations.Processes;

public abstract class CommandBuilder(string workingDirectory, string executablePath)
{
    protected readonly string WorkingDirectory = workingDirectory;
    protected readonly string ExecutablePath = executablePath;

    protected virtual Command CreateCommand(IEnumerable<string> arguments)
    {
        var command = Cli.Wrap(ExecutablePath)
            .WithArguments(arguments)
            .WithWorkingDirectory(WorkingDirectory);

        return ConfigureCommand(command);
    }
    
    protected virtual Command ConfigureCommand(Command command)
    {
        // Allow derived classes to further configure the command
        return command;
    }
}