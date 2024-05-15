// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

using System.Reflection;

namespace MasterCommander.Core;

/// <summary>
/// Serves as the base record for command options, providing mechanisms to convert properties into command line arguments.
/// </summary>
public abstract record CmdOptionsBase(params string[] InitialArguments)
{
    /// <summary>
    /// Converts the properties of the command options into an enumerable of argument strings.
    /// </summary>
    /// <param name="additionalArguments">Additional arguments to include in the result.</param>
    /// <returns>A strings enumerable representing the command line arguments.</returns>
    public IEnumerable<string> ToArguments(params string[] additionalArguments)
    {
        var arguments = ToArguments();
        return arguments.Concat(additionalArguments);
    }

    /// <summary>
    /// Converts the properties of the command options into an enumerable of argument strings.
    /// </summary>
    /// <returns>A strings enumerable representing the command line arguments.</returns>
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
            if (value == null)
            {
                continue;
            }

            // Validate against CmdOptionValuesAttribute if present
            ValidatePropertyValue(item.Property, value, item.CmdOptionValues);

            // Add argument based on the value type
            AddArgumentBasedOnValue(arguments, item.Attribute.LongOption, value);

            // Mark this property as processed to avoid processing other attributes (short/long forms) of the same property
            processedProperties.Add(item.Property.Name);
        }

        return arguments;
    }

    /// <summary>
    /// Extracts properties with command option attributes, including order and valid values.
    /// </summary>
    /// <returns>An ordered enumerable of properties and their associated attributes.</returns>
    private IEnumerable<(PropertyInfo Property, CmdOptionAttribute Attribute, int Order, CmdOptionValuesAttribute? CmdOptionValues)> ExtractPropertiesWithAttributes()
    {
        return GetType().GetProperties()
            .SelectMany(property => property.GetCustomAttributes<CmdOptionAttribute>()
                .Select(attribute => (
                    Property: property,
                    Attribute: attribute,
                    Order: property.GetCustomAttribute<CmdOptionOrderAttribute>()?.Order ?? int.MaxValue,
                    CmdOptionValues: property.GetCustomAttribute<CmdOptionValuesAttribute>())))
            .OrderBy(x => x.Order);
    }

    /// <summary>
    /// Validates the property value against specified valid options, if any.
    /// </summary>
    /// <param name="property">The property being validated.</param>
    /// <param name="value">The value of the property.</param>
    /// <param name="cmdOptionValues">The attribute specifying valid values, if present.</param>
    private static void ValidatePropertyValue(PropertyInfo property, object value, CmdOptionValuesAttribute? cmdOptionValues)
    {
        if (cmdOptionValues?.ValidOptions.Contains(value.ToString()) == false)
        {
            throw new ArgumentException($"Invalid value for {property.Name}. Valid options are: {string.Join(", ", cmdOptionValues.ValidOptions)}");
        }
    }

    /// <summary>
    /// Adds an argument to the list based on the value's type and content.
    /// </summary>
    /// <param name="arguments">The list of arguments being constructed.</param>
    /// <param name="option">The option string.</param>
    /// <param name="value">The value of the option.</param>
    private static void AddArgumentBasedOnValue(List<string> arguments, string option, object value)
    {
        if (value is true)
        {
            arguments.Add(option);
        }
        else if (value is not bool)
        {
            var valueAsString = value.ToString();

            if (string.IsNullOrWhiteSpace(valueAsString))
            {
                return;
            }

            arguments.Add(option);
            arguments.Add(valueAsString);
        }
    }
}
