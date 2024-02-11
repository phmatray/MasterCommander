#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git')

## GitCommandFactory Class

A factory for creating git command instances.

```csharp
public class GitCommandFactory : MasterCommander.Integrations.Processes.CommandBuilder,
MasterCommander.Commanders.Git.IGitCommandFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommandBuilder](CommandBuilder.md 'MasterCommander.Integrations.Processes.CommandBuilder') &#129106; GitCommandFactory

Implements [IGitCommandFactory](IGitCommandFactory.md 'MasterCommander.Commanders.Git.IGitCommandFactory')

| Constructors | |
| :--- | :--- |
| [GitCommandFactory(IDirectoryService)](GitCommandFactory.GitCommandFactory(IDirectoryService).md 'MasterCommander.Commanders.Git.GitCommandFactory.GitCommandFactory(MasterCommander.Core.Services.IDirectoryService)') | A factory for creating git command instances. |

| Properties | |
| :--- | :--- |
| [ExecutablePath](GitCommandFactory.ExecutablePath.md 'MasterCommander.Commanders.Git.GitCommandFactory.ExecutablePath') | Gets the path to the executable that the command will run. |

| Methods | |
| :--- | :--- |
| [CreateCommandCloneRepository(string, string)](GitCommandFactory.CreateCommandCloneRepository(string,string).md 'MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandCloneRepository(string, string)') | Creates a command for cloning a remote repository into a local directory. |
| [CreateCommandCommit(string)](GitCommandFactory.CreateCommandCommit(string).md 'MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandCommit(string)') | Creates a command for committing changes to the repository with a specific message. |
| [CreateCommandInit()](GitCommandFactory.CreateCommandInit().md 'MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandInit()') | Creates a command for initializing a new git repository. |
| [CreateCommandStatus()](GitCommandFactory.CreateCommandStatus().md 'MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandStatus()') | Creates a command to check the status of the git repository. |
