#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.Commanders.Docker.md 'MasterCommander.Commanders.Docker').[IDockerService](IDockerService.md 'MasterCommander.Commanders.Docker.IDockerService')

## IDockerService.BuildAsync(string, string, CancellationToken) Method

Builds a Docker image from a Dockerfile asynchronously.

```csharp
System.Threading.Tasks.Task BuildAsync(string dockerfilePath, string tag, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerService.BuildAsync(string,string,System.Threading.CancellationToken).dockerfilePath'></a>

`dockerfilePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the Dockerfile.

<a name='MasterCommander.Commanders.Docker.IDockerService.BuildAsync(string,string,System.Threading.CancellationToken).tag'></a>

`tag` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The tag to assign to the built image.

<a name='MasterCommander.Commanders.Docker.IDockerService.BuildAsync(string,string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of building a Docker image.