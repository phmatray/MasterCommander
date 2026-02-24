#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core](MasterCommander.md#MasterCommander.Core 'MasterCommander\.Core').[CmdOptionsBase](CmdOptionsBase.md 'MasterCommander\.Core\.CmdOptionsBase')

## CmdOptionsBase\.ToArguments Method

| Overloads | |
| :--- | :--- |
| [ToArguments\(\)](CmdOptionsBase.ToArguments.md#MasterCommander.Core.CmdOptionsBase.ToArguments() 'MasterCommander\.Core\.CmdOptionsBase\.ToArguments\(\)') | Converts the properties of the command options into an enumerable of argument strings\. |
| [ToArguments\(string\[\]\)](CmdOptionsBase.ToArguments.md#MasterCommander.Core.CmdOptionsBase.ToArguments(string[]) 'MasterCommander\.Core\.CmdOptionsBase\.ToArguments\(string\[\]\)') | Converts the properties of the command options into an enumerable of argument strings\. |

<a name='MasterCommander.Core.CmdOptionsBase.ToArguments()'></a>

## CmdOptionsBase\.ToArguments\(\) Method

Converts the properties of the command options into an enumerable of argument strings\.

```csharp
public System.Collections.Generic.IEnumerable<string> ToArguments();
```

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A strings enumerable representing the command line arguments\.

<a name='MasterCommander.Core.CmdOptionsBase.ToArguments(string[])'></a>

## CmdOptionsBase\.ToArguments\(string\[\]\) Method

Converts the properties of the command options into an enumerable of argument strings\.

```csharp
public System.Collections.Generic.IEnumerable<string> ToArguments(params string[] additionalArguments);
```
#### Parameters

<a name='MasterCommander.Core.CmdOptionsBase.ToArguments(string[]).additionalArguments'></a>

`additionalArguments` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Additional arguments to include in the result\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A strings enumerable representing the command line arguments\.