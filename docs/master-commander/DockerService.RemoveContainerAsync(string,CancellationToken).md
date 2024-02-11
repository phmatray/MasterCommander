#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker').[DockerService](DockerService.md 'MasterCommander.Commanders.Docker.DockerService')

## DockerService.RemoveContainerAsync(string, CancellationToken) Method

Removes a Docker container asynchronously.

```csharp
public System.Threading.Tasks.Task RemoveContainerAsync(string containerName, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerService.RemoveContainerAsync(string,System.Threading.CancellationToken).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to remove.

<a name='MasterCommander.Commanders.Docker.DockerService.RemoveContainerAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

Implements [RemoveContainerAsync(string, CancellationToken)](IDockerService.RemoveContainerAsync(string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.RemoveContainerAsync(string, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of removing a Docker container.