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
        var options = combinedOption.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
        if (options.Length == 0)
        {
            throw new ArgumentException("No command options provided.", nameof(combinedOption));
        }

        // Initialize LongOption and ShortOption with defaults
        LongOption = string.Empty;
        ShortOption = string.Empty;

        // Assign options based on prefix
        foreach (var option in options)
        {
            if (option.StartsWith("--", StringComparison.Ordinal))
            {
                LongOption = option;
            }
            else if (option.StartsWith('-'))
            {
                ShortOption = option;
            }
        }

        // Validation to ensure at least one option is provided correctly
        if (string.IsNullOrEmpty(LongOption) && string.IsNullOrEmpty(ShortOption))
        {
            throw new ArgumentException("Invalid command option format. At least one of long or short option must be correctly provided.", nameof(combinedOption));
        }
    }

    /// <summary>
    /// Gets the short form of the command option.
    /// </summary>
    /// <value>The short form of the command option, or null if not specified.</value>
    public string ShortOption { get; }

    /// <summary>
    /// Gets the long form of the command option.
    /// </summary>
    /// <value>The long form of the command option. This property is required and must be initialized.</value>
    public string LongOption { get; }
}
