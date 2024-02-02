using System.Reflection;

namespace MasterCommander.Core;

public abstract record CmdOptionsBase(params string[] initialArguments)
{
    protected IEnumerable<string> InitialArguments { get; } = [..initialArguments];
    
    public IEnumerable<string> ToArguments()
    {
        var arguments = new List<string>(InitialArguments);
        var propertiesWithAttributes = ExtractPropertiesWithAttributes();

        // Use a HashSet to keep track of properties that have already been processed
        var processedProperties = new HashSet<string>();

        foreach (var item in propertiesWithAttributes)
        {
            if (processedProperties.Contains(item.Property.Name))
            {
                // Skip if this property's command-line representation has already been processed
                continue;
            }
            
            var value = item.Property.GetValue(this);
            if (value == null) continue;
            
            // Validate against CmdOptionValuesAttribute if present
            ValidatePropertyValue(item.Property, value, item.CmdOptionValues);
            
            // Add argument based on the value type
            AddArgumentBasedOnValue(arguments, item.Attribute.Option, value);
            
            // Mark this property as processed to avoid processing other attributes (short/long forms) of the same property
            processedProperties.Add(item.Property.Name);
        }

        return arguments;
    }

    private IEnumerable<(PropertyInfo Property, CmdOptionAttribute Attribute, int Order, CmdOptionValuesAttribute? CmdOptionValues)> ExtractPropertiesWithAttributes()
    {
        return GetType().GetProperties()
            .SelectMany(property => property.GetCustomAttributes<CmdOptionAttribute>()
                .Select(attribute => (
                    Property: property,
                    Attribute: attribute,
                    Order: property.GetCustomAttribute<CmdOptionOrderAttribute>()?.Order ?? int.MaxValue,
                    CmdOptionValues: property.GetCustomAttribute<CmdOptionValuesAttribute>()
                )))
            .OrderBy(x => x.Order);
    }

    private static void ValidatePropertyValue(PropertyInfo property, object value, CmdOptionValuesAttribute? cmdOptionValues)
    {
        if (cmdOptionValues != null && !cmdOptionValues.ValidOptions.Contains(value.ToString()))
        {
            throw new ArgumentException($"Invalid value for {property.Name}. Valid options are: {string.Join(", ", cmdOptionValues.ValidOptions)}");
        }
    }

    private static void AddArgumentBasedOnValue(List<string> arguments, string option, object value)
    {
        if (value is true)
        {
            arguments.Add(option);
        }
        else if (value is not bool)
        {
            arguments.Add(option);
            arguments.Add(value.ToString());
        }
    }
}