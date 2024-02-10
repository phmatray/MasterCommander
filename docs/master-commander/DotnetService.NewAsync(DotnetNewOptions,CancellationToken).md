#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.Commanders.Dotnet.md 'MasterCommander.Commanders.Dotnet').[DotnetService](DotnetService.md 'MasterCommander.Commanders.Dotnet.DotnetService')

## DotnetService.NewAsync(DotnetNewOptions, CancellationToken) Method

Creates a new .NET project with the specified template and outputName.

```csharp
public System.Threading.Tasks.Task NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions? options=null, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.DotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions,System.Threading.CancellationToken).options'></a>

`options` [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')

The options to use.

<a name='MasterCommander.Commanders.Dotnet.DotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

Implements [NewAsync(DotnetNewOptions, CancellationToken)](IDotnetService.NewAsync(DotnetNewOptions,CancellationToken).md 'MasterCommander.Commanders.Dotnet.IDotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.