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
        string[] unexpected = ["--dry-run", "--no-update-check", "--diagnostics"];
        args.Should().ContainInOrder("dotnet", "new", "sln", "--force", "--name", "AppDemo");
        args.Should().NotContain(unexpected);
    }
}
