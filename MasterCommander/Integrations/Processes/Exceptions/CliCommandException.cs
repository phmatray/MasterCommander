namespace MasterCommander.Integrations.Processes.Exceptions;

public class CliCommandException(string message, int exitCode)
    : Exception(message)
{
    public int ExitCode { get; } = exitCode;
}