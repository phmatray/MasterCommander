#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker')

## DockerCommandFactory Class

Defines the interface for creating Docker command instances.

```csharp
public class DockerCommandFactory : MasterCommander.Integrations.Processes.CommandBuilder,
MasterCommander.Commanders.Docker.IDockerCommandFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandBuilder](CommandBuilder.md 'MasterCommander.Integrations.Processes.CommandBuilder') &#129106; DockerCommandFactory

Implements [IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander.Commanders.Docker.IDockerCommandFactory')

| Constructors | |
| :--- | :--- |
| [DockerCommandFactory(IDirectoryService)](DockerCommandFactory.DockerCommandFactory(IDirectoryService).md 'MasterCommander.Commanders.Docker.DockerCommandFactory.DockerCommandFactory(MasterCommander.Core.Services.IDirectoryService)') | Defines the interface for creating Docker command instances. |

| Properties | |
| :--- | :--- |
| [ExecutablePath](DockerCommandFactory.ExecutablePath.md 'MasterCommander.Commanders.Docker.DockerCommandFactory.ExecutablePath') | Gets the path to the executable that the command will run. |

| Methods | |
| :--- | :--- |
| [CreateCommandBuild(string, string)](DockerCommandFactory.CreateCommandBuild(string,string).md 'MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandBuild(string, string)') | Creates a command to build a Docker image from a Dockerfile. |
| [CreateCommandRemoveContainer(string)](DockerCommandFactory.CreateCommandRemoveContainer(string).md 'MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRemoveContainer(string)') | Creates a command to remove a Docker container. |
| [CreateCommandRun(string, string)](DockerCommandFactory.CreateCommandRun(string,string).md 'MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRun(string, string)') | Creates a command to run a Docker container from an image. |
| [CreateCommandStop(string)](DockerCommandFactory.CreateCommandStop(string).md 'MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandStop(string)') | Creates a command to stop a running Docker container. |
