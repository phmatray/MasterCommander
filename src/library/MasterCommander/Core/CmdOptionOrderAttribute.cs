// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core;

/// <summary>
/// Specifies the order in which command option attributes should be processed.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class CmdOptionOrderAttribute(int order) : Attribute
{
    /// <summary>
    /// Gets the order in which the command option should be processed.
    /// </summary>
    public int Order { get; } = order;
}
