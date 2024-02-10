#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.Commanders.Git.md 'MasterCommander.Commanders.Git').[IGitService](IGitService.md 'MasterCommander.Commanders.Git.IGitService')

## IGitService.StatusAsync(CancellationToken) Method

Checks the status of the Git repository asynchronously.

```csharp
System.Threading.Tasks.Task StatusAsync(System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Git.IGitService.StatusAsync(System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous status operation, providing the status of the repository.