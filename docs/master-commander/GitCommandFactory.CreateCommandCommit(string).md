#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[GitCommandFactory](GitCommandFactory.md 'MasterCommander.Commanders.Git.GitCommandFactory')

## GitCommandFactory.CreateCommandCommit(string) Method

Creates a command for committing changes to the repository with a specific message.

```csharp
public CliWrap.Command CreateCommandCommit(string message);
```
#### Parameters

<a name='MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandCommit(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The commit message to use.

Implements [CreateCommandCommit(string)](IGitCommandFactory.CreateCommandCommit(string).md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandCommit(string)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to commit changes to the repository.