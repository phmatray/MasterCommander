#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander\.Commanders\.Docker').[IDockerService](IDockerService.md 'MasterCommander\.Commanders\.Docker\.IDockerService')

## IDockerService\.StopAsync\(string, CancellationToken\) Method

Stops a running Docker container asynchronously\.

```csharp
System.Threading.Tasks.Task StopAsync(string containerName, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerService.StopAsync(string,System.Threading.CancellationToken).containerName'></a>

`containerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the container to stop\.

<a name='MasterCommander.Commanders.Docker.IDockerService.StopAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

Optional cancellation token to cancel the operation\.

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A task representing the asynchronous operation of stopping a Docker container\.