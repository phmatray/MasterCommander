#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Git](MasterCommander.md#MasterCommander.Commanders.Git 'MasterCommander\.Commanders\.Git').[GitCommandFactory](GitCommandFactory.md 'MasterCommander\.Commanders\.Git\.GitCommandFactory')

## GitCommandFactory\.CreateCommandCloneRepository\(string, string\) Method

Creates a command for cloning a remote repository into a local directory\.

```csharp
public CliWrap.Command CreateCommandCloneRepository(string repositoryUrl, string localPath);
```
#### Parameters

<a name='MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandCloneRepository(string,string).repositoryUrl'></a>

`repositoryUrl` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The URL of the remote repository to clone\.

<a name='MasterCommander.Commanders.Git.GitCommandFactory.CreateCommandCloneRepository(string,string).localPath'></a>

`localPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The local directory path where the repository should be cloned\.

Implements [CreateCommandCloneRepository\(string, string\)](IGitCommandFactory.CreateCommandCloneRepository(string,string).md 'MasterCommander\.Commanders\.Git\.IGitCommandFactory\.CreateCommandCloneRepository\(string, string\)')

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to clone the repository\.