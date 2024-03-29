#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker').[IDockerService](IDockerService.md 'MasterCommander.Commanders.Docker.IDockerService')

## IDockerService.RemoveContainerAsync(string, CancellationToken) Method

Removes a Docker container asynchronously.

```csharp
System.Threading.Tasks.Task RemoveContainerAsync(string containerName, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerService.RemoveContainerAsync(string,System.Threading.CancellationToken).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to remove.

<a name='MasterCommander.Commanders.Docker.IDockerService.RemoveContainerAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of removing a Docker container.