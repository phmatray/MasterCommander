#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet.CmdNew.Options](MasterCommander.md#MasterCommander.Commanders.Dotnet.CmdNew.Options 'MasterCommander.Commanders.Dotnet.CmdNew.Options').[DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')

## DotnetNewOptions(string) Constructor

Represents options for the 'dotnet new' command, which creates a .NET project or other artifacts based on a template.  
This record encapsulates common and template-specific options that can be passed to the command.

```csharp
public DotnetNewOptions(string Template);
```
#### Parameters

<a name='MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.DotnetNewOptions(string).Template'></a>

`Template` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The template to instantiate when the command is invoked. Each template might have specific options you can pass.