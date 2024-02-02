namespace MasterCommander.Tests;

public class CmdOptionsBaseTests
{
    private record TestOptions : CmdOptionsBase
    {
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

        public TestOptions() : base("dotnet", "new", "sln")
        {
        }
    }

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
        var args = options.ToArguments();

        // Assert
        args.Should().ContainInOrder("dotnet", "new", "sln", "--force", "--name", "AppDemo");
        args.Should().NotContain(new[] { "--dry-run", "--no-update-check", "--diagnostics" });
    }
}