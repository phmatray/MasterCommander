#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core](MasterCommander.md#MasterCommander.Core 'MasterCommander.Core').[CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase')

## CmdOptionsBase.ExtractPropertiesWithAttributes() Method

Extracts properties with command option attributes, including order and valid values.

```csharp
private System.Collections.Generic.IEnumerable<(System.Reflection.PropertyInfo Property,MasterCommander.Core.CmdOptionAttribute Attribute,int Order,MasterCommander.Core.CmdOptionValuesAttribute? CmdOptionValues)> ExtractPropertiesWithAttributes();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[CmdOptionAttribute](CmdOptionAttribute.md 'MasterCommander.Core.CmdOptionAttribute')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[CmdOptionValuesAttribute](CmdOptionValuesAttribute.md 'MasterCommander.Core.CmdOptionValuesAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An ordered enumerable of properties and their associated attributes.