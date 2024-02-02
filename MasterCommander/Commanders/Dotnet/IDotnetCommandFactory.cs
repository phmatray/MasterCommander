namespace MasterCommander.Commanders.Dotnet;

public interface IDotnetCommandFactory
{
    Command New(DotnetNewOptions options);
    Command Build(DotnetBuildOptions options);
    Command Run(DotnetRunOptions options);
    Command Test();
    Command SlnAdd(string csproj);
}