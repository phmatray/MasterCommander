namespace MasterCommander.Core;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] 
public class CmdOptionAttribute : Attribute
{
    public string? ShortOption { get; private set; }
    public string LongOption { get; private set; }

    public CmdOptionAttribute(string combinedOption)
    {
        // Split the input on the delimiter, considering cases where there might not be a delimiter
        var options = combinedOption.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

        // Assign the appropriate option based on its prefix
        foreach (var option in options)
        {
            if (option.StartsWith("--"))
            {
                LongOption = option;
            }
            else if (option.StartsWith("-") && option.Length > 1) // Check for short option validity
            {
                ShortOption = option;
            }
        }

        // Handle cases where only one form is provided
        if (options.Length == 1)
        {
            var option = options[0];
            if (!option.StartsWith('-'))
            {
                throw new ArgumentException("Invalid command option format. Options must start with '-' for short form or '--' for long form.", nameof(combinedOption));
            }

            // If it's a short option without a long option provided, or vice versa
            if (option.StartsWith("--"))
            {
                LongOption = option; // Long option provided without a short option
            }
            else if (option.StartsWith('-') && option.Length > 1)
            {
                ShortOption = option; // Short option provided without a long option
            }
        }
    }
}