#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[DotnetCommandFactory](DotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.DotnetCommandFactory')

## DotnetCommandFactory.CreateCommandNew(DotnetNewOptions) Method

Creates a new command to create a new .NET project or file.

```csharp
public CliWrap.Command CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions options);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.DotnetCommandFactory.CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions).options'></a>

`options` [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')

The options for creating a new .NET project or file.

Implements [CreateCommandNew(DotnetNewOptions)](IDotnetCommandFactory.CreateCommandNew(DotnetNewOptions).md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions)')

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to create a new .NET project or file.