#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core](MasterCommander.md#MasterCommander.Core 'MasterCommander.Core').[CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase')

## CmdOptionsBase.ToArguments(string[]) Method

Converts the properties of the command options into an enumerable of argument strings.

```csharp
public System.Collections.Generic.IEnumerable<string> ToArguments(params string[] additionalArguments);
```
#### Parameters

<a name='MasterCommander.Core.CmdOptionsBase.ToArguments(string[]).additionalArguments'></a>

`additionalArguments` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Additional arguments to include in the result.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A strings enumerable representing the command line arguments.