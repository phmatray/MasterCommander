namespace MasterCommander.Commanders.Docker;

public interface IDockerService
{
    Task BuildAsync(string dockerfilePath, string tag, CancellationToken ct = default);
    Task RunAsync(string image, string? containerName = null, CancellationToken ct = default);
    Task StopAsync(string containerName, CancellationToken ct = default);
    Task RemoveContainerAsync(string containerName, CancellationToken ct = default);
}