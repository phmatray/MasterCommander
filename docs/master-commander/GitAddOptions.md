#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Commanders.Git.CmdAdd](MasterCommander.md#MasterCommander.Commanders.Git.CmdAdd 'MasterCommander.Commanders.Git.CmdAdd')

## GitAddOptions Class

Represents the options available for the git add command.

```csharp
public class GitAddOptions : MasterCommander.Core.CmdOptionsBase,
System.IEquatable<MasterCommander.Commanders.Git.CmdAdd.GitAddOptions>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase') &#129106; GitAddOptions

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[GitAddOptions](GitAddOptions.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [GitAddOptions()](GitAddOptions.GitAddOptions().md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions.GitAddOptions()') | Represents the options available for the git add command. |

| Properties | |
| :--- | :--- |
| [DryRun](GitAddOptions.DryRun.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions.DryRun') | Gets a value indicating whether to not actually add the file(s), just show if they exist and/or will be ignored. |
| [Force](GitAddOptions.Force.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions.Force') | Gets a value indicating whether to allow adding otherwise ignored files. |
| [Update](GitAddOptions.Update.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions.Update') | Gets a value indicating whether to update the index just where it already has an entry matching pathspec. |
| [Verbose](GitAddOptions.Verbose.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions.Verbose') | Gets a value indicating whether be verbose. |
