namespace MasterCommander.Integrations.Processes.Exceptions;

public class CliOperationException(string message, Exception innerException)
    : Exception(message, innerException);