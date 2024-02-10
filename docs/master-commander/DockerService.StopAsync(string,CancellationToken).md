#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker').[DockerService](DockerService.md 'MasterCommander.Commanders.Docker.DockerService')

## DockerService.StopAsync(string, CancellationToken) Method

Stops a running Docker container asynchronously.

```csharp
public System.Threading.Tasks.Task StopAsync(string containerName, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerService.StopAsync(string,System.Threading.CancellationToken).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to stop.

<a name='MasterCommander.Commanders.Docker.DockerService.StopAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

Implements [StopAsync(string, CancellationToken)](IDockerService.StopAsync(string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.StopAsync(string, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of stopping a Docker container.