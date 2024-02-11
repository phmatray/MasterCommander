#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[IGitCommandFactory](IGitCommandFactory.md 'MasterCommander.Commanders.Git.IGitCommandFactory')

## IGitCommandFactory.CreateCommandCommit(string) Method

Creates a command for committing changes to the repository with a specific message.

```csharp
CliWrap.Command CreateCommandCommit(string message);
```
#### Parameters

<a name='MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandCommit(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The commit message to use.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to commit changes to the repository.