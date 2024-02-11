#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory')

## IDotnetCommandFactory.CreateCommandRun(DotnetRunOptions) Method

Creates a new command to run a .NET project.

```csharp
CliWrap.Command CreateCommandRun(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions options);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandRun(MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions).options'></a>

`options` [DotnetRunOptions](DotnetRunOptions.md 'MasterCommander.Commanders.Dotnet.CmdRun.DotnetRunOptions')

The options for running the .NET project.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to run a .NET project.