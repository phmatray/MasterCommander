#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker')

## IDockerService Interface

Provides an interface for managing Docker operations asynchronously.

```csharp
public interface IDockerService
```

Derived  
&#8627; [DockerService](DockerService.md 'MasterCommander.Commanders.Docker.DockerService')

| Methods | |
| :--- | :--- |
| [BuildAsync(string, string, CancellationToken)](IDockerService.BuildAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.BuildAsync(string, string, System.Threading.CancellationToken)') | Builds a Docker image from a Dockerfile asynchronously. |
| [RemoveContainerAsync(string, CancellationToken)](IDockerService.RemoveContainerAsync(string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.RemoveContainerAsync(string, System.Threading.CancellationToken)') | Removes a Docker container asynchronously. |
| [RunAsync(string, string, CancellationToken)](IDockerService.RunAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.RunAsync(string, string, System.Threading.CancellationToken)') | Runs a Docker container from an image asynchronously. |
| [StopAsync(string, CancellationToken)](IDockerService.StopAsync(string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.StopAsync(string, System.Threading.CancellationToken)') | Stops a running Docker container asynchronously. |
