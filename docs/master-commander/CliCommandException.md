#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core\.Exceptions](MasterCommander.md#MasterCommander.Core.Exceptions 'MasterCommander\.Core\.Exceptions')

## CliCommandException Class

Represents an exception related to CLI command execution failures, including the associated exit code\.

```csharp
public class CliCommandException : System.Exception
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') &#129106; CliCommandException

| Constructors | |
| :--- | :--- |
| [CliCommandException\(string, int\)](CliCommandException.CliCommandException(string,int).md 'MasterCommander\.Core\.Exceptions\.CliCommandException\.CliCommandException\(string, int\)') | Initializes a new instance of the [CliCommandException](CliCommandException.md 'MasterCommander\.Core\.Exceptions\.CliCommandException') class\. |

| Properties | |
| :--- | :--- |
| [ExitCode](CliCommandException.ExitCode.md 'MasterCommander\.Core\.Exceptions\.CliCommandException\.ExitCode') | Gets the exit code associated with the CLI command failure\. |
