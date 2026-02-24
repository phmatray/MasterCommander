#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander\.Commanders\.Dotnet').[IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander\.Commanders\.Dotnet\.IDotnetCommandFactory')

## IDotnetCommandFactory\.CreateCommandBuild\(DotnetBuildOptions\) Method

Creates a new command to build a \.NET project\.

```csharp
CliWrap.Command CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions options);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandBuild(MasterCommander.Commanders.Dotnet.CmdBuild.DotnetBuildOptions).options'></a>

`options` [DotnetBuildOptions](DotnetBuildOptions.md 'MasterCommander\.Commanders\.Dotnet\.CmdBuild\.DotnetBuildOptions')

The options for building the \.NET project\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A command to build a \.NET project\.