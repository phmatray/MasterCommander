#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet').[DotnetService](DotnetService.md 'MasterCommander.Commanders.Dotnet.DotnetService')

## DotnetService.BuildAsync(DotnetBuildOptions, CancellationToken) Method

Builds the .NET project.

```csharp
public System.Threading.Tasks.Task BuildAsync(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions? options=null, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.DotnetService.BuildAsync(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions,System.Threading.CancellationToken).options'></a>

`options` [DotnetBuildOptions](DotnetBuildOptions.md 'MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions')

The options to use.

<a name='MasterCommander.Commanders.Dotnet.DotnetService.BuildAsync(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

Implements [BuildAsync(DotnetBuildOptions, CancellationToken)](IDotnetService.BuildAsync(DotnetBuildOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.BuildAsync(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.