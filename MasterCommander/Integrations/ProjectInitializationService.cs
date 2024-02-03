namespace MasterCommander.Integrations;

public class ProjectInitializationService(IGitService gitService, IDotnetService dotnetService, IConsole console)
    : IProjectInitializationService
{
    private const string SdkVersion = "8.0.101";
    private const string SolutionName = "AppDemo";
    private const string ConsoleProjectName = $"{SolutionName}.Console";
    private const string ConsoleProjectDirectory = $"src/{ConsoleProjectName}";
    private const string ConsoleCsproj = $"{ConsoleProjectDirectory}/{ConsoleProjectName}.csproj";
    
    public async Task InitializeConsoleProjectAsync()
    {
        console.WriteStartupMessage();

        await gitService.InitAsync();
        await gitService.StatusAsync();
        await dotnetService.NewAsync(new DotnetNewGitignoreOptions());
        await dotnetService.NewAsync(new DotnetNewEditorConfigOptions());
        await dotnetService.NewAsync(new DotnetNewNuGetConfigOptions());
        await dotnetService.NewAsync(new DotnetNewGlobalJsonOptions { SdkVersion = SdkVersion });
        await dotnetService.NewAsync(new DotnetNewSolutionOptions { OutputName = SolutionName });
        await dotnetService.NewAsync(new DotnetNewConsoleOptions { OutputName = ConsoleProjectName, OutputDirectory = ConsoleProjectDirectory });
        await dotnetService.SlnAddAsync(ConsoleCsproj);
        await dotnetService.BuildAsync();
        await dotnetService.BuildAsync(new DotnetBuildOptions { Configuration = "Release" });
        await dotnetService.RunAsync(new DotnetRunOptions { Project = ConsoleCsproj, Configuration = "Release" });
    }
}