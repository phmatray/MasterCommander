#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet.CmdNew.Options](MasterCommander.md#MasterCommander.Commanders.Dotnet.CmdNew.Options 'MasterCommander.Commanders.Dotnet.CmdNew.Options')

## DotnetNewOptions Class

Represents options for the 'dotnet new' command, which creates a .NET project or other artifacts based on a template.  
This record encapsulates common and template-specific options that can be passed to the command.

```csharp
public class DotnetNewOptions : MasterCommander.Core.CmdOptionsBase,
System.IEquatable<MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') &#129106; DotnetNewOptions

Derived  
&#8627; [DotnetNewClassLibraryOptions](DotnetNewClassLibraryOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions')  
&#8627; [DotnetNewEditorConfigOptions](DotnetNewEditorConfigOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewEditorConfigOptions')  
&#8627; [DotnetNewGitignoreOptions](DotnetNewGitignoreOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewGitignoreOptions')  
&#8627; [DotnetNewGlobalJsonOptions](DotnetNewGlobalJsonOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewGlobalJsonOptions')  
&#8627; [DotnetNewNuGetConfigOptions](DotnetNewNuGetConfigOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewNuGetConfigOptions')  
&#8627; [DotnetNewSolutionOptions](DotnetNewSolutionOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewSolutionOptions')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [DotnetNewOptions(string)](DotnetNewOptions.DotnetNewOptions(string).md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.DotnetNewOptions(string)') | Represents options for the 'dotnet new' command, which creates a .NET project or other artifacts based on a template.<br/>This record encapsulates common and template-specific options that can be passed to the command. |

| Properties | |
| :--- | :--- |
| [Diagnostics](DotnetNewOptions.Diagnostics.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.Diagnostics') | Gets a value indicating whether to enable diagnostic output for the command. |
| [DryRun](DotnetNewOptions.DryRun.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.DryRun') | Gets a value indicating whether to perform a dry run of the command without making any changes. |
| [Force](DotnetNewOptions.Force.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.Force') | Gets a value indicating whether to force content to be generated even if it would overwrite existing files. |
| [Language](DotnetNewOptions.Language.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.Language') | Gets the programming language of the template to create. |
| [NoUpdateCheck](DotnetNewOptions.NoUpdateCheck.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.NoUpdateCheck') | Gets a value indicating whether to skip the automatic check for template updates. |
| [OutputDirectory](DotnetNewOptions.OutputDirectory.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.OutputDirectory') | Gets the output directory where the generated artifacts should be placed. |
| [OutputName](DotnetNewOptions.OutputName.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.OutputName') | Gets the name for the output being created. If not specified, the name of the current directory is used. |
| [ProjectPath](DotnetNewOptions.ProjectPath.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.ProjectPath') | Gets the path to the project file to consider for additional configuration options. |
| [Template](DotnetNewOptions.Template.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.Template') | The template to instantiate when the command is invoked. Each template might have specific options you can pass. |
| [Verbosity](DotnetNewOptions.Verbosity.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions.Verbosity') | Gets the verbosity level of the command's output. |
