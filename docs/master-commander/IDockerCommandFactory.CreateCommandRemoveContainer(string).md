#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander\.Commanders\.Docker').[IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander\.Commanders\.Docker\.IDockerCommandFactory')

## IDockerCommandFactory\.CreateCommandRemoveContainer\(string\) Method

Creates a command to remove a Docker container\.

```csharp
CliWrap.Command CreateCommandRemoveContainer(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRemoveContainer(string).containerName'></a>

`containerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the container to remove\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to remove a Docker container\.