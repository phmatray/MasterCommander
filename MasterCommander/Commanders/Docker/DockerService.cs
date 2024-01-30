namespace MasterCommander.Commanders.Docker;

public class DockerService(DockerCommandFactory dockerCommandFactory, IConsole console)
    : CommandOutputHandler(console)
{
    public async Task BuildAsync(string dockerfilePath, string tag, CancellationToken ct = default)
    {
        await dockerCommandFactory
            .Build(dockerfilePath, tag)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    public async Task RunAsync(string image, string? containerName = null, CancellationToken ct = default)
    {
        await dockerCommandFactory
            .Run(image, containerName)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    public async Task StopAsync(string containerName, CancellationToken ct = default)
    {
        await dockerCommandFactory
            .Stop(containerName)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
    
    public async Task RemoveContainerAsync(string containerName, CancellationToken ct = default)
    {
        await dockerCommandFactory
            .RemoveContainer(containerName)
            .Observe(ct)
            .ForEachAsync(HandleCommandEvent, ct);
    }
}