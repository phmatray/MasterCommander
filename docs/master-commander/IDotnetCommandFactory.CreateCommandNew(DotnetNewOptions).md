#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet](MasterCommander.md#MasterCommander.Commanders.Dotnet 'MasterCommander.Commanders.Dotnet').[IDotnetCommandFactory](IDotnetCommandFactory.md 'MasterCommander.Commanders.Dotnet.IDotnetCommandFactory')

## IDotnetCommandFactory.CreateCommandNew(DotnetNewOptions) Method

Creates a new command to create a new .NET project or file.

```csharp
CliWrap.Command CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions options);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.IDotnetCommandFactory.CreateCommandNew(MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions).options'></a>

`options` [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')

The options for creating a new .NET project or file.

#### Returns
[CliWrap.Command](https://docs.microsoft.com/en-us/dotnet/api/CliWrap.Command 'CliWrap.Command')  
A command to create a new .NET project or file.