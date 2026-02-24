#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core](MasterCommander.md#MasterCommander.Core 'MasterCommander\.Core').[CmdOptionAttribute](CmdOptionAttribute.md 'MasterCommander\.Core\.CmdOptionAttribute')

## CmdOptionAttribute\(string\) Constructor

Initializes a new instance of the [CmdOptionAttribute](CmdOptionAttribute.md 'MasterCommander\.Core\.CmdOptionAttribute') class with the specified combined option\.

```csharp
public CmdOptionAttribute(string combinedOption);
```
#### Parameters

<a name='MasterCommander.Core.CmdOptionAttribute.CmdOptionAttribute(string).combinedOption'></a>

`combinedOption` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The combined string containing both the short and long form of the command option, separated by a '\|'\. For example, "\-s\|\-\-long\-option"\.

#### Exceptions

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown when the provided option does not start with '\-' indicating an invalid format\.