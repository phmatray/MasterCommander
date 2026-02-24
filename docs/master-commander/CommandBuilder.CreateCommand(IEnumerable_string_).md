#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Integrations\.Processes](MasterCommander.md#MasterCommander.Integrations.Processes 'MasterCommander\.Integrations\.Processes').[CommandBuilder](CommandBuilder.md 'MasterCommander\.Integrations\.Processes\.CommandBuilder')

## CommandBuilder\.CreateCommand\(IEnumerable\<string\>\) Method

Creates a command with the specified arguments, configuring the executable path and working directory\.

```csharp
protected virtual CliWrap.Command CreateCommand(System.Collections.Generic.IEnumerable<string> arguments);
```
#### Parameters

<a name='MasterCommander.Integrations.Processes.CommandBuilder.CreateCommand(System.Collections.Generic.IEnumerable_string_).arguments'></a>

`arguments` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The arguments to pass to the executable\.

#### Returns
[CliWrap\.Command](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.command 'CliWrap\.Command')  
A configured command\.