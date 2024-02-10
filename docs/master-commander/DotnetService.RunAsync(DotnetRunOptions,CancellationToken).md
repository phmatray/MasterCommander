#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet').[DotnetService](DotnetService.md 'MasterCommander.Commanders.Dotnet.DotnetService')

## DotnetService.RunAsync(DotnetRunOptions, CancellationToken) Method

Runs the .NET project.

```csharp
public System.Threading.Tasks.Task RunAsync(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions? options=null, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.DotnetService.RunAsync(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions,System.Threading.CancellationToken).options'></a>

`options` [DotnetRunOptions](DotnetRunOptions.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions')

The options to use.

<a name='MasterCommander.Commanders.Dotnet.DotnetService.RunAsync(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

Implements [RunAsync(DotnetRunOptions, CancellationToken)](IDotnetService.RunAsync(DotnetRunOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.RunAsync(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.