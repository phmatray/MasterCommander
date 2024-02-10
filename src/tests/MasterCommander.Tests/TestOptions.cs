// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Tests;

internal sealed record TestOptions : CmdOptionsBase
{
    public TestOptions()
        : base("dotnet", "new", "sln")
    {
    }

    [CmdOption("--dry-run")]
    public bool DryRun { get; init; }

    [CmdOption("--force")]
    public bool Force { get; init; }

    [CmdOption("--name")]
    public string? Name { get; init; }

    [CmdOption("--no-update-check")]
    public bool NoUpdateCheck { get; init; }

    [CmdOption("--diagnostics")]
    public bool Diagnostics { get; init; }
}
