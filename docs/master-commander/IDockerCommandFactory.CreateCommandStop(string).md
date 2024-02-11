#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander.Commanders.Docker').[IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander.Commanders.Docker.IDockerCommandFactory')

## IDockerCommandFactory.CreateCommandStop(string) Method

Creates a command to stop a running Docker container.

```csharp
CliWrap.Command CreateCommandStop(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandStop(string).containerName'></a>

`containerName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the container to stop.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to stop a Docker container.