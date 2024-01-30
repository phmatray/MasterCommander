namespace MasterCommander.Commanders.Dotnet;

public class DotnetCommandFactory(
    string workingDirectory = ".",
    string executablePath = "dotnet")
    : CommandRunner(workingDirectory, executablePath)
{
    public Command New(string template, string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(template);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        
        string[] arguments = ["new", template, "-n", name];
        return CreateCommand(arguments);
    }

    public Command Build()
    {
        string[] arguments = ["build"];
        return CreateCommand(arguments);
    }

    public Command Run()
    {
        string[] arguments = ["run"];
        return CreateCommand(arguments);
    }

    public Command Test()
    {
        string[] arguments = ["test"];
        return CreateCommand(arguments);
    }
}