#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core](MasterCommander.Core.md 'MasterCommander.Core').[CmdOptionsBase](CmdOptionsBase.md 'MasterCommander.Core.CmdOptionsBase')

## CmdOptionsBase.ValidatePropertyValue(PropertyInfo, object, CmdOptionValuesAttribute) Method

Validates the property value against specified valid options, if any.

```csharp
private static void ValidatePropertyValue(System.Reflection.PropertyInfo property, object value, MasterCommander.Core.CmdOptionValuesAttribute? cmdOptionValues);
```
#### Parameters

<a name='MasterCommander.Core.CmdOptionsBase.ValidatePropertyValue(System.Reflection.PropertyInfo,object,MasterCommander.Core.CmdOptionValuesAttribute).property'></a>

`property` [System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')

The property being validated.

<a name='MasterCommander.Core.CmdOptionsBase.ValidatePropertyValue(System.Reflection.PropertyInfo,object,MasterCommander.Core.CmdOptionValuesAttribute).value'></a>

`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The value of the property.

<a name='MasterCommander.Core.CmdOptionsBase.ValidatePropertyValue(System.Reflection.PropertyInfo,object,MasterCommander.Core.CmdOptionValuesAttribute).cmdOptionValues'></a>

`cmdOptionValues` [CmdOptionValuesAttribute](CmdOptionValuesAttribute.md 'MasterCommander.Core.CmdOptionValuesAttribute')

The attribute specifying valid values, if present.