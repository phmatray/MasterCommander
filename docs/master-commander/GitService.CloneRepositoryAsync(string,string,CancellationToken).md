#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[GitService](GitService.md 'MasterCommander.Commanders.Git.GitService')

## GitService.CloneRepositoryAsync(string, string, CancellationToken) Method

Clones a remote Git repository into a local directory asynchronously.

```csharp
public System.Threading.Tasks.Task CloneRepositoryAsync(string repositoryUrl, string localPath, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Git.GitService.CloneRepositoryAsync(string,string,System.Threading.CancellationToken).repositoryUrl'></a>

`repositoryUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The URL of the remote repository to clone.

<a name='MasterCommander.Commanders.Git.GitService.CloneRepositoryAsync(string,string,System.Threading.CancellationToken).localPath'></a>

`localPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The local path where to clone the repository.

<a name='MasterCommander.Commanders.Git.GitService.CloneRepositoryAsync(string,string,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

Implements [CloneRepositoryAsync(string, string, CancellationToken)](IGitService.CloneRepositoryAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.CloneRepositoryAsync(string, string, System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous clone operation.