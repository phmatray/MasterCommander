#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander\.Commanders\.Dotnet').[IDotnetService](IDotnetService.md 'MasterCommander\.Commanders\.Dotnet\.IDotnetService')

## IDotnetService\.TestAsync\(CancellationToken\) Method

Runs the tests in the \.NET project\.

```csharp
System.Threading.Tasks.Task TestAsync(System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetService.TestAsync(System.Threading.CancellationToken).ct'></a>

`ct` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token\.

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A [System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task') representing the asynchronous operation\.