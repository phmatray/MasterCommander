#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git')

## GitService Class

Provides an implementation for interacting with Git repositories asynchronously.

```csharp
public class GitService : MasterCommander.Integrations.Processes.CommandOutputHandler,
MasterCommander.Commanders.Git.IGitService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandOutputHandler](CommandOutputHandler.md 'MasterCommander.Integrations.Processes.CommandOutputHandler') &#129106; GitService

Implements [IGitService](IGitService.md 'MasterCommander.Commanders.Git.IGitService')

| Constructors | |
| :--- | :--- |
| [GitService(IGitCommandFactory, IConsole)](GitService.GitService(IGitCommandFactory,IConsole).md 'MasterCommander.Commanders.Git.GitService.GitService(MasterCommander.Commanders.Git.IGitCommandFactory, MasterCommander.Core.Display.IConsole)') | Provides an implementation for interacting with Git repositories asynchronously. |

| Methods | |
| :--- | :--- |
| [AddAsync(string, GitAddOptions, CancellationToken)](GitService.AddAsync(string,GitAddOptions,CancellationToken).md 'MasterCommander.Commanders.Git.GitService.AddAsync(string, MasterCommander.Commanders.Git.CmdAdd.GitAddOptions, System.Threading.CancellationToken)') | Adds a file to the Git repository asynchronously. |
| [CloneRepositoryAsync(string, string, CancellationToken)](GitService.CloneRepositoryAsync(string,string,CancellationToken).md 'MasterCommander.Commanders.Git.GitService.CloneRepositoryAsync(string, string, System.Threading.CancellationToken)') | Clones a remote Git repository into a local directory asynchronously. |
| [CommitAsync(string, CancellationToken)](GitService.CommitAsync(string,CancellationToken).md 'MasterCommander.Commanders.Git.GitService.CommitAsync(string, System.Threading.CancellationToken)') | Commits changes to the Git repository asynchronously with a specific message. |
| [InitAsync(CancellationToken)](GitService.InitAsync(CancellationToken).md 'MasterCommander.Commanders.Git.GitService.InitAsync(System.Threading.CancellationToken)') | Initializes a new Git repository asynchronously. |
| [StatusAsync(CancellationToken)](GitService.StatusAsync(CancellationToken).md 'MasterCommander.Commanders.Git.GitService.StatusAsync(System.Threading.CancellationToken)') | Checks the status of the Git repository asynchronously. |
