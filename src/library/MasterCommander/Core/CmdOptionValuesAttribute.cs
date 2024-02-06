// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core;

/// <summary>
/// Specifies valid values for a command option attribute.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class CmdOptionValuesAttribute(string[] validOptions) : Attribute
{
    /// <summary>
    /// Gets the array of valid options for the command option.
    /// </summary>
    public string[] ValidOptions { get; } = validOptions;
}
