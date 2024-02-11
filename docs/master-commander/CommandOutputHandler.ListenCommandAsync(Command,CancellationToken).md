#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Integrations.Processes](MasterCommander.md#MasterCommander.Integrations.Processes 'MasterCommander.Integrations.Processes').[CommandOutputHandler](CommandOutputHandler.md 'MasterCommander.Integrations.Processes.CommandOutputHandler')

## CommandOutputHandler.ListenCommandAsync(Command, CancellationToken) Method

Listens for and processes command execution events asynchronously, writing output and events to the console.

```csharp
protected System.Threading.Tasks.Task ListenCommandAsync(CliWrap.Command command, System.Threading.CancellationToken ct);
```
#### Parameters

<a name='MasterCommander.Integrations.Processes.CommandOutputHandler.ListenCommandAsync(CliWrap.Command,System.Threading.CancellationToken).command'></a>

`command` [CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')

The command whose output is to be handled.

<a name='MasterCommander.Integrations.Processes.CommandOutputHandler.ListenCommandAsync(CliWrap.Command,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

A cancellation token that can be used to cancel the listening operation.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of listening to and handling command output and events.