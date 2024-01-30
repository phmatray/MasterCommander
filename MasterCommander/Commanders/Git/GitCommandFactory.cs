namespace MasterCommander.Commanders.Git;

public class GitCommandFactory(
    string workingDirectory = ".",
    string executablePath = "git")
    : CommandBuilder(workingDirectory, executablePath), IGitCommandFactory
{
    public Command Init()
    {
        string[] arguments = ["init"];
        return CreateCommand(arguments);
    }
    
    public Command Status()
    {
        string[] arguments = ["status"];
        return CreateCommand(arguments);
    }

    public Command CloneRepository(string repositoryUrl, string localPath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(repositoryUrl);
        ArgumentException.ThrowIfNullOrWhiteSpace(localPath);
        
        string[] arguments = ["clone", repositoryUrl, localPath];
        return CreateCommand(arguments);
    }

    public Command Commit(string message)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        
        string[] arguments = ["commit", "-m", message];
        return CreateCommand(arguments);
    }
}