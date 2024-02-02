namespace MasterCommander.Tests;

public class DotnetNewOptionsTests
{
    [Fact]
    public void ToArguments_ShouldGenerateCorrectArguments_WhenAllPropertiesAreSet()
    {
        // Arrange
        var options = new DotnetNewOptions("console")
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
}