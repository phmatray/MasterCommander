#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Integrations\.Processes](MasterCommander.md#MasterCommander.Integrations.Processes 'MasterCommander\.Integrations\.Processes').[CommandBuilder](CommandBuilder.md 'MasterCommander\.Integrations\.Processes\.CommandBuilder')

## CommandBuilder\.ConfigureCommand\(Command\) Method

Allows derived classes to further configure the command before execution\.
This method can be overridden to apply additional configurations like environment variables, timeout settings, etc\.

```csharp
protected virtual CliWrap.Command ConfigureCommand(CliWrap.Command command);
```
#### Parameters

<a name='MasterCommander.Integrations.Processes.CommandBuilder.ConfigureCommand(CliWrap.Command).command'></a>

`command` [CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')

The command to configure\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
The configured command\.