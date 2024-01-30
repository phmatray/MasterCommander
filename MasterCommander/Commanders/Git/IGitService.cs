namespace MasterCommander.Commanders.Git;

public interface IGitService
{
    Task InitAsync(CancellationToken ct = default);
    Task StatusAsync(CancellationToken ct = default);
    Task CloneRepositoryAsync(string repositoryUrl, string localPath, CancellationToken ct = default);
    Task CommitAsync(string message, CancellationToken ct = default);
}