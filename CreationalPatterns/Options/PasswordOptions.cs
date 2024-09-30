namespace CreationalPatterns.Options;

public class PasswordOptions
{
    public int Min { get; set; } = 3;
    public int Max { get; set; } = 6;
    public bool HasDigit { get; init; } = false;
    public bool HasUpper { get; init; } = false;
    public bool HasSpecial { get; init; } = false;
}