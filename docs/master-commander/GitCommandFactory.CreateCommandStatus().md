#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[GitCommandFactory](GitCommandFactory.md 'MasterCommander.Commanders.Git.GitCommandFactory')

## GitCommandFactory.CreateCommandStatus() Method

Creates a command to check the status of the git repository.

```csharp
public CliWrap.Command CreateCommandStatus();
```

Implements [CreateCommandStatus()](IGitCommandFactory.CreateCommandStatus().md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandStatus()')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to display the status of the repository.