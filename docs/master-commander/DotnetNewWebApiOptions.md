#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options](MasterCommander.md#MasterCommander.Commanders.Dotnet.CmdNew.Options 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options')

## DotnetNewWebApiOptions Class

Options for creating a new web API project\.

```csharp
public record DotnetNewWebApiOptions : MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewClassLibraryOptions, MasterCommander.Commanders.Dotnet.CmdNew.Abstractions.IHasUseProgramMain, System.IEquatable<MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewWebApiOptions>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander\.Core\.CmdOptionsBase') &#129106; [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options\.DotnetNewOptions') &#129106; [DotnetNewClassLibraryOptions](DotnetNewClassLibraryOptions.md 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options\.DotnetNewClassLibraryOptions') &#129106; DotnetNewWebApiOptions

Implements [IHasUseProgramMain](IHasUseProgramMain.md 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Abstractions\.IHasUseProgramMain'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[DotnetNewWebApiOptions](DotnetNewWebApiOptions.md 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options\.DotnetNewWebApiOptions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [DotnetNewWebApiOptions\(\)](DotnetNewWebApiOptions.DotnetNewWebApiOptions().md 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options\.DotnetNewWebApiOptions\.DotnetNewWebApiOptions\(\)') | Options for creating a new web API project\. |

| Properties | |
| :--- | :--- |
| [UseProgramMain](DotnetNewWebApiOptions.UseProgramMain.md 'MasterCommander\.Commanders\.Dotnet\.CmdNew\.Options\.DotnetNewWebApiOptions\.UseProgramMain') | Gets a value indicating whether to use a Program\.Main entry point\. |
