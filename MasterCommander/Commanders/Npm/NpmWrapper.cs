namespace MasterCommander.Commanders.Npm;

public class NpmCommandFactory(
    string workingDirectory = ".",
    string executablePath = "npm")
    : CommandBuilder(workingDirectory, executablePath), INpmCommandFactory
{
    public Command Init()
    {
        string[] arguments = ["init"];
        return CreateCommand(arguments);
    }
    
    public Command Install()
    {
        string[] arguments = ["install"];
        return CreateCommand(arguments);
    }

    public Command Update()
    {
        string[] arguments = ["update"];
        return CreateCommand(arguments);
    }

    public Command Start()
    {
        string[] arguments = ["start"];
        return CreateCommand(arguments);
    }

    public Command RunScript(string scriptName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(scriptName);
        
        string[] arguments = ["run", scriptName];
        return CreateCommand(arguments);
    }
}