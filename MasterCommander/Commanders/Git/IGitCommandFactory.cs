namespace MasterCommander.Commanders.Git;

public interface IGitCommandFactory
{
    Command Init();
    Command Status();
    Command CloneRepository(string repositoryUrl, string localPath);
    Command Commit(string message);
}