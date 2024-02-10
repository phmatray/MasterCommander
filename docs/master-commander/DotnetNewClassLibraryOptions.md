#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Dotnet.CmdNew.Options](MasterCommander.Commanders.Dotnet.CmdNew.Options.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options')

## DotnetNewClassLibraryOptions Class

Options for creating a new .NET class library project with specific configurations.

```csharp
public class DotnetNewClassLibraryOptions : MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions,
MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasFramework,
MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasLangVersion,
MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasNoRestore,
System.IEquatable<MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') &#129106; [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions') &#129106; DotnetNewClassLibraryOptions

Derived  
&#8627; [DotnetNewConsoleOptions](DotnetNewConsoleOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewConsoleOptions')  
&#8627; [DotnetNewWebApiOptions](DotnetNewWebApiOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWebApiOptions')  
&#8627; [DotnetNewWpfCustomControlLibOptions](DotnetNewWpfCustomControlLibOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfCustomControlLibOptions')  
&#8627; [DotnetNewWpfLibOptions](DotnetNewWpfLibOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfLibOptions')  
&#8627; [DotnetNewWpfOptions](DotnetNewWpfOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfOptions')  
&#8627; [DotnetNewWpfUserControlLibOptions](DotnetNewWpfUserControlLibOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWpfUserControlLibOptions')

Implements [IHasFramework](IHasFramework.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasFramework'), [IHasLangVersion](IHasLangVersion.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasLangVersion'), [IHasNoRestore](IHasNoRestore.md 'MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasNoRestore'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[DotnetNewClassLibraryOptions](DotnetNewClassLibraryOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [DotnetNewClassLibraryOptions(string)](DotnetNewClassLibraryOptions.DotnetNewClassLibraryOptions(string).md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions.DotnetNewClassLibraryOptions(string)') | Options for creating a new .NET class library project with specific configurations. |

| Properties | |
| :--- | :--- |
| [Framework](DotnetNewClassLibraryOptions.Framework.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions.Framework') | Gets the target framework for the class library. |
| [LangVersion](DotnetNewClassLibraryOptions.LangVersion.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions.LangVersion') | Gets the language version to use for the class library. |
| [NoRestore](DotnetNewClassLibraryOptions.NoRestore.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions.NoRestore') | Gets a value indicating whether to skip the automatic restore when the project is created. |
