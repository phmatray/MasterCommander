#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Exceptions](MasterCommander.md#MasterCommander.Core.Exceptions 'MasterCommander.Core.Exceptions')

## CliCommandException Class

Represents an exception related to CLI command execution failures, including the associated exit code.

```csharp
public class CliCommandException : System.Exception
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; CliCommandException

| Constructors | |
| :--- | :--- |
| [CliCommandException(string, int)](CliCommandException.CliCommandException(string,int).md 'MasterCommander.Core.Exceptions.CliCommandException.CliCommandException(string, int)') | Initializes a new instance of the [CliCommandException](CliCommandException.md 'MasterCommander.Core.Exceptions.CliCommandException') class. |

| Properties | |
| :--- | :--- |
| [ExitCode](CliCommandException.ExitCode.topic 'MasterCommander.Core.Exceptions.CliCommandException.ExitCode') | Gets the exit code associated with the CLI command failure. |
