#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core](MasterCommander.md#MasterCommander.Core 'MasterCommander\.Core').[CmdOptionsBase](CmdOptionsBase.md 'MasterCommander\.Core\.CmdOptionsBase')

## CmdOptionsBase\.ExtractPropertiesWithAttributes\(\) Method

Extracts properties with command option attributes, including order and valid values\.

```csharp
private System.Collections.Generic.IEnumerable<(System.Reflection.PropertyInfo Property,MasterCommander.Core.CmdOptionAttribute Attribute,int Order,MasterCommander.Core.CmdOptionValuesAttribute? CmdOptionValues)> ExtractPropertiesWithAttributes();
```

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.valuetuple 'System\.ValueTuple')[System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')[,](https://learn.microsoft.com/en-us/dotnet/api/system.valuetuple 'System\.ValueTuple')[CmdOptionAttribute](CmdOptionAttribute.md 'MasterCommander\.Core\.CmdOptionAttribute')[,](https://learn.microsoft.com/en-us/dotnet/api/system.valuetuple 'System\.ValueTuple')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.valuetuple 'System\.ValueTuple')[CmdOptionValuesAttribute](CmdOptionValuesAttribute.md 'MasterCommander\.Core\.CmdOptionValuesAttribute')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.valuetuple 'System\.ValueTuple')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
An ordered enumerable of properties and their associated attributes\.