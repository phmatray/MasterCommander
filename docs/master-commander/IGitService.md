#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git')

## IGitService Interface

Provides an interface for interacting with Git repositories asynchronously.

```csharp
public interface IGitService
```

Derived  
&#8627; [GitService](GitService.md 'MasterCommander.Commanders.Git.GitService')

| Methods | |
| :--- | :--- |
| [AddAsync(string, GitAddOptions, CancellationToken)](IGitService.AddAsync(string,GitAddOptions,CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.AddAsync(string, MasterCommander.Commanders.Git.CmdAdd.GitAddOptions, System.Threading.CancellationToken)') | Adds a file to the Git repository asynchronously. |
| [CloneRepositoryAsync(string, string, CancellationToken)](IGitService.CloneRepositoryAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.CloneRepositoryAsync(string, string, System.Threading.CancellationToken)') | Clones a remote Git repository into a local directory asynchronously. |
| [CommitAsync(string, CancellationToken)](IGitService.CommitAsync(string,CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.CommitAsync(string, System.Threading.CancellationToken)') | Commits changes to the Git repository asynchronously with a specific message. |
| [InitAsync(CancellationToken)](IGitService.InitAsync(CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.InitAsync(System.Threading.CancellationToken)') | Initializes a new Git repository asynchronously. |
| [StatusAsync(CancellationToken)](IGitService.StatusAsync(CancellationToken).md 'MasterCommander.Commanders.Git.IGitService.StatusAsync(System.Threading.CancellationToken)') | Checks the status of the Git repository asynchronously. |
