namespace MasterCommander.Commanders.Docker;

public class DockerService(
    IDockerCommandFactory dockerCommandFactory, IConsole console)
    : CommandOutputHandler(console), IDockerService
{
    public async Task BuildAsync(string dockerfilePath, string tag, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.Build(dockerfilePath, tag);
        await ObserveCommandAsync(command, ct);
    }
    
    public async Task RunAsync(string image, string? containerName = null, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.Run(image, containerName);
        await ObserveCommandAsync(command, ct);
    }

    public async Task StopAsync(string containerName, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.Stop(containerName);
        await ObserveCommandAsync(command, ct);
    }

    public async Task RemoveContainerAsync(string containerName, CancellationToken ct = default)
    {
        var command = dockerCommandFactory.RemoveContainer(containerName);
        await ObserveCommandAsync(command, ct);
    }
}