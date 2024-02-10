#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker')

## IDockerCommandFactory Interface

Defines the interface for creating Docker command instances.

```csharp
public interface IDockerCommandFactory
```

Derived  
&#8627; [DockerCommandFactory](DockerCommandFactory.md 'MasterCommander.Commanders.Docker.DockerCommandFactory')

| Methods | |
| :--- | :--- |
| [CreateCommandBuild(string, string)](IDockerCommandFactory.CreateCommandBuild(string,string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandBuild(string, string)') | Creates a command to build a Docker image from a Dockerfile. |
| [CreateCommandRemoveContainer(string)](IDockerCommandFactory.CreateCommandRemoveContainer(string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRemoveContainer(string)') | Creates a command to remove a Docker container. |
| [CreateCommandRun(string, string)](IDockerCommandFactory.CreateCommandRun(string,string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRun(string, string)') | Creates a command to run a Docker container from an image. |
| [CreateCommandStop(string)](IDockerCommandFactory.CreateCommandStop(string).md 'MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandStop(string)') | Creates a command to stop a running Docker container. |
