namespace MasterCommander.Commanders.Docker;

public class DockerCommandFactory(
    string workingDirectory = ".",
    string executablePath = "docker")
    : CommandBuilder(workingDirectory, executablePath), IDockerCommandFactory
{
    public Command Build(string dockerfilePath, string tag)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(dockerfilePath);
        ArgumentException.ThrowIfNullOrWhiteSpace(tag);

        string[] arguments = ["build", "-f", dockerfilePath, "-t", tag, "."];
        return CreateCommand(arguments);
    }

    public Command Run(string image, string? containerName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(image);

        string[] arguments = string.IsNullOrWhiteSpace(containerName)
            ? ["run", image]
            : ["run", "--name", containerName, image];

        return CreateCommand(arguments);
    }

    public Command Stop(string containerName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(containerName);

        string[] arguments = ["stop", containerName];
        return CreateCommand(arguments);
    }

    public Command RemoveContainer(string containerName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(containerName);

        string[] arguments = ["rm", containerName];
        return CreateCommand(arguments);
    }

    // Additional Docker commands can be implemented here...
}