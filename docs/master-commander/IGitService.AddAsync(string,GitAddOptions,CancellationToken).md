#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[IGitService](IGitService.md 'MasterCommander.Commanders.Git.IGitService')

## IGitService.AddAsync(string, GitAddOptions, CancellationToken) Method

Adds a file to the Git repository asynchronously.

```csharp
System.Threading.Tasks.Task AddAsync(string pathSpec, MasterCommander.Commanders.Git.CmdAdd.GitAddOptions? options=null, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Git.IGitService.AddAsync(string,MasterCommander.Commanders.Git.CmdAdd.GitAddOptions,System.Threading.CancellationToken).pathSpec'></a>

`pathSpec` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the file to add.

<a name='MasterCommander.Commanders.Git.IGitService.AddAsync(string,MasterCommander.Commanders.Git.CmdAdd.GitAddOptions,System.Threading.CancellationToken).options'></a>

`options` [GitAddOptions](GitAddOptions.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions')

Optional options for the add operation.

<a name='MasterCommander.Commanders.Git.IGitService.AddAsync(string,MasterCommander.Commanders.Git.CmdAdd.GitAddOptions,System.Threading.CancellationToken).ct'></a>

`ct` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Optional cancellation token to cancel the operation.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous add operation.