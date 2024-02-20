#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Exceptions](MasterCommander.md#MasterCommander.Core.Exceptions 'MasterCommander.Core.Exceptions').[CliCommandException](CliCommandException.md 'MasterCommander.Core.Exceptions.CliCommandException')

## CliCommandException(string, int) Constructor

Initializes a new instance of the [CliCommandException](CliCommandException.md 'MasterCommander.Core.Exceptions.CliCommandException') class.

```csharp
public CliCommandException(string? message, int exitCode);
```
#### Parameters

<a name='MasterCommander.Core.Exceptions.CliCommandException.CliCommandException(string,int).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message that explains the reason for the exception.

<a name='MasterCommander.Core.Exceptions.CliCommandException.CliCommandException(string,int).exitCode'></a>

`exitCode` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The exit code returned by the CLI command.