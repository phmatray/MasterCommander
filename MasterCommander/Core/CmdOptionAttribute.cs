namespace MasterCommander.Core;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] 
public class CmdOptionAttribute(string option, bool isShortForm = false)
    : Attribute
{
    public string Option { get; } = option;

    public bool IsShortForm { get; } = isShortForm;
}