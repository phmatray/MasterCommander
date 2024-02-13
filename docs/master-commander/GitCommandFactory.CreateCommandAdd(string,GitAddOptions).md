#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander.Commanders.Git').[GitCommandFactory](GitCommandFactory.md 'MasterCommander.Commanders.Git.GitCommandFactory')

## GitCommandFactory.CreateCommandAdd(string, GitAddOptions) Method

Creates a command to add a file or directory to the git repository.

```csharp
public CliWrap.Command CreateCommandAdd(string pathSpec, MasterCommander.Commanders.Git.CmdAdd.GitAddOptions options);
```
#### Parameters

<a name='MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandAdd(string,MasterCommander.Commanders.Git.CmdAdd.GitAddOptions).pathSpec'></a>

`pathSpec` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to the file or directory to add.

<a name='MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandAdd(string,MasterCommander.Commanders.Git.CmdAdd.GitAddOptions).options'></a>

`options` [GitAddOptions](GitAddOptions.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions')

The options for adding the file or directory.

Implements [CreateCommandAdd(string, GitAddOptions)](IGitCommandFactory.CreateCommandAdd(string,GitAddOptions).md 'MasterCommander.Commanders.Git.IGitCommandFactory.CreateCommandAdd(string, MasterCommander.Commanders.Git.CmdAdd.GitAddOptions)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to add a file or directory to the repository.