#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.Commanders.Npm.md 'MasterCommander.Commanders.Npm').[NpmService](NpmService.md 'MasterCommander.Commanders.Npm.NpmService')

## NpmService.UpdateAsync(CancellationToken) Method

Updates npm packages for the project asynchronously.

```csharp
public System.Threading.Tasks.Task UpdateAsync(System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Npm.NpmService.UpdateAsync(System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

Implements [UpdateAsync(CancellationToken)](INpmService.UpdateAsync(CancellationToken).md 'MasterCommander.Commanders.Npm.INpmService.UpdateAsync(System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of updating npm packages.