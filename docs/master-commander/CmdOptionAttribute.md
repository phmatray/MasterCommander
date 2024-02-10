#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core](MasterCommander.Core.md 'MasterCommander.Core')

## CmdOptionAttribute Class

Specifies a command option attribute for properties to indicate their corresponding command line option.

```csharp
public class CmdOptionAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; CmdOptionAttribute

### Remarks
This attribute supports defining both short and long form options for command line arguments.

| Constructors | |
| :--- | :--- |
| [CmdOptionAttribute(string)](CmdOptionAttribute.CmdOptionAttribute(string).md 'MasterCommander.Core.CmdOptionAttribute.CmdOptionAttribute(string)') | Initializes a new instance of the [CmdOptionAttribute](CmdOptionAttribute.md 'MasterCommander.Core.CmdOptionAttribute') class with the specified combined option. |

| Properties | |
| :--- | :--- |
| [LongOption](CmdOptionAttribute.LongOption.md 'MasterCommander.Core.CmdOptionAttribute.LongOption') | Gets the long form of the command option. |
| [ShortOption](CmdOptionAttribute.ShortOption.md 'MasterCommander.Core.CmdOptionAttribute.ShortOption') | Gets the short form of the command option. |
