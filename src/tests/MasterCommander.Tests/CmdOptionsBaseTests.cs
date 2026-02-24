// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Tests;

public class CmdOptionsBaseTests
{
    [Fact]
    public void ToArguments_ShouldNotIncludeFalseBooleans()
    {
        // Arrange
        var options = new TestOptions
        {
            DryRun = false,
            Force = true,
            Name = "AppDemo",
            NoUpdateCheck = false,
            Diagnostics = false
        };

        // Act
        var args = options.ToArguments().ToList();

        // Assert
        var expected = new[] { "dotnet", "new", "sln", "--force", "--name", "AppDemo" };
        args.ShouldBe(expected);
        args.ShouldNotContain("--dry-run");
        args.ShouldNotContain("--no-update-check");
        args.ShouldNotContain("--diagnostics");
    }
}
