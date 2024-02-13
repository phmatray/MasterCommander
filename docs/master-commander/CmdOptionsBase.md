#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core](MasterCommander.md#MasterCommander.Core 'MasterCommander.Core')

## CmdOptionsBase Class

Serves as the base record for command options, providing mechanisms to convert properties into command line arguments.

```csharp
public abstract class CmdOptionsBase :
System.IEquatable<MasterCommander.Core.CmdOptionsBase>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CmdOptionsBase

Derived  
&#8627; [DotnetNewOptions](DotnetNewOptions.md 'MasterCommander.Commanders.Dotnet.CmdNew.Options.DotnetNewOptions')  
&#8627; [DotnetCommandOptionsBase](DotnetCommandOptionsBase.md 'MasterCommander.Commanders.Dotnet.DotnetCommandOptionsBase')  
&#8627; [GitAddOptions](GitAddOptions.md 'MasterCommander.Commanders.Git.CmdAdd.GitAddOptions')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [CmdOptionsBase(string[])](CmdOptionsBase.CmdOptionsBase(string[]).md 'MasterCommander.Core.CmdOptionsBase.CmdOptionsBase(string[])') | Serves as the base record for command options, providing mechanisms to convert properties into command line arguments. |

| Methods | |
| :--- | :--- |
| [AddArgumentBasedOnValue(List&lt;string&gt;, string, object)](CmdOptionsBase.AddArgumentBasedOnValue(List_string_,string,object).md 'MasterCommander.Core.CmdOptionsBase.AddArgumentBasedOnValue(System.Collections.Generic.List<string>, string, object)') | Adds an argument to the list based on the value's type and content. |
| [ExtractPropertiesWithAttributes()](CmdOptionsBase.ExtractPropertiesWithAttributes().md 'MasterCommander.Core.CmdOptionsBase.ExtractPropertiesWithAttributes()') | Extracts properties with command option attributes, including order and valid values. |
| [ToArguments()](CmdOptionsBase.ToArguments().md 'MasterCommander.Core.CmdOptionsBase.ToArguments()') | Converts the properties of the command options into an enumerable of argument strings. |
| [ToArguments(string[])](CmdOptionsBase.ToArguments(string[]).md 'MasterCommander.Core.CmdOptionsBase.ToArguments(string[])') | Converts the properties of the command options into an enumerable of argument strings. |
| [ValidatePropertyValue(PropertyInfo, object, CmdOptionValuesAttribute)](CmdOptionsBase.ValidatePropertyValue(PropertyInfo,object,CmdOptionValuesAttribute).md 'MasterCommander.Core.CmdOptionsBase.ValidatePropertyValue(System.Reflection.PropertyInfo, object, MasterCommander.Core.CmdOptionValuesAttribute)') | Validates the property value against specified valid options, if any. |
