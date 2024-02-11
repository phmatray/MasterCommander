#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[GitService](GitService.md 'MasterCommander.Commanders.Git.GitService')

## GitService.CommitAsync(string, CancellationToken) Method

Commits changes to the Git repository asynchronously with a specific message.

```csharp
public System.Threading.Tasks.Task CommitAsync(string message, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Git.GitService.CommitAsync(string,System.Threading.CancellationToken).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The commit message.

<a name='MasterCommander.Commanders.Git.GitService.CommitAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

Implements [CommitAsync(string, CancellationToken)](IGitService.CommitAsync(string,CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.CommitAsync(string, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous commit operation.