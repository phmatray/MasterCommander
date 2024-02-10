#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.Commanders.Git.md 'MasterCommander.Commanders.Git')

## IGitCommandFactory Interface

Defines the interface for creating git command instances.

```csharp
public interface IGitCommandFactory
```

Derived  
&#8627; [GitCommandFactory](GitCommandFactory.md 'MasterCommander.Commanders.Git.GitCommandFactory')

| Methods | |
| :--- | :--- |
| [CreateCommandCloneRepository(string, string)](IGitCommandFactory.CreateCommandCloneRepository(string,string).md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandCloneRepository(string, string)') | Creates a command for cloning a remote repository into a local directory. |
| [CreateCommandCommit(string)](IGitCommandFactory.CreateCommandCommit(string).md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandCommit(string)') | Creates a command for committing changes to the repository with a specific message. |
| [CreateCommandInit()](IGitCommandFactory.CreateCommandInit().md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandInit()') | Creates a command for initializing a new git repository. |
| [CreateCommandStatus()](IGitCommandFactory.CreateCommandStatus().md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandStatus()') | Creates a command to check the status of the git repository. |
