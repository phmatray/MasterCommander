#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander\.Commanders\.Docker').[DockerCommandFactory](DockerCommandFactory.md 'MasterCommander\.Commanders\.Docker\.DockerCommandFactory')

## DockerCommandFactory\.CreateCommandStop\(string\) Method

Creates a command to stop a running Docker container\.

```csharp
public CliWrap.Command CreateCommandStop(string containerName);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandStop(string).containerName'></a>

`containerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the container to stop\.

Implements [CreateCommandStop\(string\)](IDockerCommandFactory.CreateCommandStop(string).md 'MasterCommander\.Commanders\.Docker\.IDockerCommandFactory\.CreateCommandStop\(string\)')

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to stop a Docker container\.