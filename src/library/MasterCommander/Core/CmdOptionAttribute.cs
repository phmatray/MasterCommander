// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core;

/// <summary>
/// Specifies a command option attribute for properties to indicate their corresponding command line option.
/// </summary>
/// <remarks>
/// This attribute supports defining both short and long form options for command line arguments.
/// </remarks>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class CmdOptionAttribute : Attribute
{
    private static readonly char[] _separator = ['|'];

    /// <summary>
    /// Initializes a new instance of the <see cref="CmdOptionAttribute"/> class with the specified combined option.
    /// </summary>
    /// <param name="combinedOption">The combined string containing both the short and long form of the command option, separated by a '|'. For example, "-s|--long-option".</param>
    /// <exception cref="ArgumentException">Thrown when the provided option does not start with '-' indicating an invalid format.</exception>
    public CmdOptionAttribute(string combinedOption)
    {
        // Split the input on the delimiter, considering cases where there might not be a delimiter
        var options = combinedOption.Split(_separator, StringSplitOptions.RemoveEmptyEntries);

        // Assign the appropriate option based on its prefix
        foreach (var option in options)
        {
            if (option.StartsWith("--", StringComparison.InvariantCulture))
            {
                LongOption = option;
            }
            else if (option.StartsWith('-') && option.Length > 1)
            {
                // Check for short option validity
                ShortOption = option;
            }
        }

        // Handle cases where only one form is provided
        if (options.Length == 1)
        {
            var option = options[0];
            if (!option.StartsWith('-'))
            {
                throw new ArgumentException("Invalid command option format. Options must start with '-' for short form or '--' for long form.", nameof(combinedOption));
            }

            // If it's a short option without a long option provided, or vice versa
            if (option.StartsWith("--", StringComparison.InvariantCulture))
            {
                LongOption = option; // Long option provided without a short option
            }
            else if (option.StartsWith('-') && option.Length > 1)
            {
                ShortOption = option; // Short option provided without a long option
            }
        }
    }

    /// <summary>
    /// Gets the short form of the command option.
    /// </summary>
    /// <value>The short form of the command option, or null if not specified.</value>
    public string? ShortOption { get; private set; }

    /// <summary>
    /// Gets the long form of the command option.
    /// </summary>
    /// <value>The long form of the command option. This property is required and must be initialized.</value>
    public string LongOption { get; private set; }
}
