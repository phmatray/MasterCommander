#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[IDotnetService](IDotnetService.md 'MasterCommander.Commanders.Dotnet.IDotnetService')

## IDotnetService.SlnAddAsync(string, CancellationToken) Method

Adds the specified .NET project to the solution.

```csharp
System.Threading.Tasks.Task SlnAddAsync(string csproj, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetService.SlnAddAsync(string,System.Threading.CancellationToken).csproj'></a>

`csproj` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the .NET project.

<a name='MasterCommander.Commanders.Dotnet.IDotnetService.SlnAddAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.