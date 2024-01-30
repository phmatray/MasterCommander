namespace MasterCommander.Integrations.Processes.Exceptions;

public class CliOperationCanceledException(string message)
    : OperationCanceledException(message);