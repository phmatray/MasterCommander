#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[IDotnetService](IDotnetService.md 'MasterCommander.Commanders.Dotnet.IDotnetService')

## IDotnetService.NewAsync(DotnetNewOptions, CancellationToken) Method

Creates a new .NET project with the specified template and outputName.

```csharp
System.Threading.Tasks.Task NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions? options=null, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions,System.Threading.CancellationToken).options'></a>

`options` [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')

The options to use.

<a name='MasterCommander.Commanders.Dotnet.IDotnetService.NewAsync(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.