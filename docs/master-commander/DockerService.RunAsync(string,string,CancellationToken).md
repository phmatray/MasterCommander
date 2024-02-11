#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker').[DockerService](DockerService.md 'MasterCommander.Commanders.Docker.DockerService')

## DockerService.RunAsync(string, string, CancellationToken) Method

Runs a Docker container from an image asynchronously.

```csharp
public System.Threading.Tasks.Task RunAsync(string image, string? containerName=null, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerService.RunAsync(string,string,System.Threading.CancellationToken).image'></a>

`image` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Docker image to run.

<a name='MasterCommander.Commanders.Docker.DockerService.RunAsync(string,string,System.Threading.CancellationToken).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Optional name for the container.

<a name='MasterCommander.Commanders.Docker.DockerService.RunAsync(string,string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

Implements [RunAsync(string, string, CancellationToken)](IDockerService.RunAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Docker.IDockerService.RunAsync(string, string, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of running a Docker container.