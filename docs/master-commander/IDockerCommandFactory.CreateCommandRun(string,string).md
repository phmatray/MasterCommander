#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Docker](MasterCommander.md#MasterCommander.Commanders.Docker 'MasterCommander\.Commanders\.Docker').[IDockerCommandFactory](IDockerCommandFactory.md 'MasterCommander\.Commanders\.Docker\.IDockerCommandFactory')

## IDockerCommandFactory\.CreateCommandRun\(string, string\) Method

Creates a command to run a Docker container from an image\.

```csharp
CliWrap.Command CreateCommandRun(string image, string? containerName=null);
```
#### Parameters

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRun(string,string).image'></a>

`image` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The Docker image to run\.

<a name='MasterCommander.Commanders.Docker.IDockerCommandFactory.CreateCommandRun(string,string).containerName'></a>

`containerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional name for the container\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to run a Docker container\.