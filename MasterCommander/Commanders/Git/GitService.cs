namespace MasterCommander.Commanders.Git;

public class GitService(
    IGitCommandFactory gitCommandFactory, IConsole console)
    : CommandOutputHandler(console), IGitService
{
    public async Task InitAsync(CancellationToken ct = default)
    {
        await gitCommandFactory
            .Init()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    public async Task StatusAsync(CancellationToken ct = default)
    {
        await gitCommandFactory
            .Status()
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    public async Task CloneRepositoryAsync(string repositoryUrl, string localPath, CancellationToken ct = default)
    {
        await gitCommandFactory
            .CloneRepository(repositoryUrl, localPath)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    public async Task CommitAsync(string message, CancellationToken ct = default)
    {
        await gitCommandFactory
            .Commit(message)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
}