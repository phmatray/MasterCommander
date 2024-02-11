#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker').[IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander.Commanders.Docker.IDockerCommandFactory')

## IDockerCommandFactory.CreateCommandRemoveContainer(string) Method

Creates a command to remove a Docker container.

```csharp
CliWrap.Command CreateCommandRemoveContainer(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRemoveContainer(string).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to remove.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to remove a Docker container.