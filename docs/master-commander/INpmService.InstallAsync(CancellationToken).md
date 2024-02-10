#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Npm](MasterCommander.Commanders.Npm.md 'MasterCommander.Commanders.Npm').[INpmService](INpmService.md 'MasterCommander.Commanders.Npm.INpmService')

## INpmService.InstallAsync(CancellationToken) Method

Installs npm packages for the project asynchronously.

```csharp
System.Threading.Tasks.Task InstallAsync(System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Npm.INpmService.InstallAsync(System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task representing the asynchronous operation of installing npm packages.