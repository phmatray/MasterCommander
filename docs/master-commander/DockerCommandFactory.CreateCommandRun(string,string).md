#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander\.Commanders\.Docker').[DockerCommandFactory](DockerCommandFactory.md 'MasterCommander\.Commanders\.Docker\.DockerCommandFactory')

## DockerCommandFactory\.CreateCommandRun\(string, string\) Method

Creates a command to run a Docker container from an image\.

```csharp
public CliWrap.Command CreateCommandRun(string image, string? containerName=null);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRun(string,string).image'></a>

`image` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The Docker image to run\.

<a name='MasterCommander.Commanders.Docker.DockerCommandFactory.CreateCommandRun(string,string).containerName'></a>

`containerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional name for the container\.

Implements [CreateCommandRun\(string, string\)](IDockerCommandFactory.CreateCommandRun(string,string).md 'MasterCommander\.Commanders\.Docker\.IDockerCommandFactory\.CreateCommandRun\(string, string\)')

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to run a Docker container\.