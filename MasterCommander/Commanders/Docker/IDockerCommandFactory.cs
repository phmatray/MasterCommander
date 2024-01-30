namespace MasterCommander.Commanders.Docker;

public interface IDockerCommandFactory
{
    Command Build(string dockerfilePath, string tag);
    Command Run(string image, string? containerName = null);
    Command Stop(string containerName);
    Command RemoveContainer(string containerName);
}