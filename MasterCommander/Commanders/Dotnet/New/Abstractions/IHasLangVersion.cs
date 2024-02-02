namespace MasterCommander.Commanders.Dotnet.New.Abstractions;

public interface IHasLangVersion
{
    string? LangVersion { get; init; }
}