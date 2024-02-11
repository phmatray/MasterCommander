#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker')

## DockerService Class

Provides Docker related operations.

```csharp
public class DockerService : MasterCommander.Integrations.Processes.CommandOutputHandler,
MasterCommander.Commanders.Docker.IDockerService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandOutputHandler](CommandOutputHandler.md 'MasterCommander.Integrations.Processes.CommandOutputHandler') &#129106; DockerService

Implements [IDockerService](IDockerService.md 'MasterCommander.Commanders.Docker.IDockerService')

| Constructors | |
| :--- | :--- |
| [DockerService(IDockerCommandFactory, IConsole)](DockerService.DockerService(IDockerCommandFactory,IConsole).md 'MasterCommander.Commanders.Docker.DockerService.DockerService(MasterCommander.Commanders.Docker.IDockerCommandFactory, MasterCommander.Core.Display.IConsole)') | Provides Docker related operations. |

| Methods | |
| :--- | :--- |
| [BuildAsync(string, string, CancellationToken)](DockerService.BuildAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Docker.DockerService.BuildAsync(string, string, System.Threading.CancellationToken)') | Builds a Docker image from a Dockerfile asynchronously. |
| [RemoveContainerAsync(string, CancellationToken)](DockerService.RemoveContainerAsync(string,CancellationToken).md 'MasterCommander.Commanders.Docker.DockerService.RemoveContainerAsync(string, System.Threading.CancellationToken)') | Removes a Docker container asynchronously. |
| [RunAsync(string, string, CancellationToken)](DockerService.RunAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Docker.DockerService.RunAsync(string, string, System.Threading.CancellationToken)') | Runs a Docker container from an image asynchronously. |
| [StopAsync(string, CancellationToken)](DockerService.StopAsync(string,CancellationToken).md 'MasterCommander.Commanders.Docker.DockerService.StopAsync(string, System.Threading.CancellationToken)') | Stops a running Docker container asynchronously. |
