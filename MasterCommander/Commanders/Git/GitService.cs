namespace MasterCommander.Commanders.Git;

public class GitService(
    IGitCommandFactory gitCommandFactory,
    IConsole console)
    : CommandOutputHandler(console), IGitService
{
    public async Task InitAsync(CancellationToken ct = default)
    {
        var command = gitCommandFactory.Init();
        await ListenCommandAsync(command, ct);
    }

    public async Task StatusAsync(CancellationToken ct = default)
    {
        var command = gitCommandFactory.Status();
        await ListenCommandAsync(command, ct);
    }
    
    public async Task CloneRepositoryAsync(string repositoryUrl, string localPath, CancellationToken ct = default)
    {
        var command = gitCommandFactory.CloneRepository(repositoryUrl, localPath);
        await ListenCommandAsync(command, ct);
    }
    
    public async Task CommitAsync(string message, CancellationToken ct = default)
    {
        var command = gitCommandFactory.Commit(message);
        await ListenCommandAsync(command, ct);
    }
}