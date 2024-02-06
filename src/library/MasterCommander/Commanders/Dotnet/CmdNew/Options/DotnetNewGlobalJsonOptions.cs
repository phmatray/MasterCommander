// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Commanders.Dotnet.CmdNew.Options;

/// <summary>
/// Options for creating a new global.json file.
/// </summary>
public record DotnetNewGlobalJsonOptions()
    : DotnetNewOptions("globaljson")
{
    /// <summary>
    /// Gets the SDK version to use.
    /// </summary>
    [CmdOption("--sdk-version")]
    [CmdOptionOrder(11)]
    public string? SdkVersion { get; init; }
}
