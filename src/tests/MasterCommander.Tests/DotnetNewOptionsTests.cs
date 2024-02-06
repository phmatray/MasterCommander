// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using MasterCommander.Commanders.Dotnet.CmdNew.Options;

namespace MasterCommander.Tests;

public class DotnetNewOptionsTests
{
    [Fact]
    public void ToArguments_ShouldGenerateCorrectArguments_WhenAllPropertiesAreSet()
    {
        // Arrange
        var options = new DotnetNewConsoleOptions
        {
            OutputName = "MyApp",
            Force = true,
            Language = "C#",
            Framework = "net8.0"
        };

        // Act
        var args = options.ToArguments();

        // Assert
        args.Should().ContainInConsecutiveOrder("new", "console", "--force", "--language", "C#", "--name", "MyApp", "--framework", "net8.0");
    }

    [Fact]
    public void ToArguments_ShouldOmitOptionalArguments_WhenNotSet()
    {
        // Arrange
        var options = new DotnetNewOptions("console");

        // Act
        var args = options.ToArguments();

        // Assert
        args.Should().ContainInOrder("new", "console");
        args.Should().NotContain("--name", "--force", "--language", "--framework");
    }

    [Fact]
    public void ToArguments_ShouldThrowArgumentException_ForInvalidEnumValue()
    {
        // Arrange
        var options = new DotnetNewOptions("console")
        {
            Language = "C++"
        };

        // Act
        var act = () => options.ToArguments();

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Invalid value for Language. Valid options are: C#, F#, VB");
    }

    [Fact]
    public void ToArguments_ShouldRespectExplicitOrder_AndHandleComplexPropertiesCorrectly()
    {
        // Arrange: Assuming 'Options' might evolve to include complex properties or more nuanced ordering requirements
        var options = new DotnetNewWebApiOptions
        {
            OutputName = "AdvancedAPI",
            Framework = "net8.0",
            Force = true,
            Language = "F#"
        };

        // Act
        var args = options.ToArguments();

        // Assert
        args.Should().ContainInConsecutiveOrder("new", "webapi", "--force", "--language", "F#", "--name", "AdvancedAPI", "--framework", "net8.0");
    }
}
