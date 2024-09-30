namespace CreationalPatterns.Options;

public class PasswordChecker
{

    private PasswordOptions _options;

    public PasswordChecker(PasswordOptions options)
    {
        _options = options;
    }


    public PasswordChecker(Func<PasswordOptions, PasswordOptions> options)
    {
        _options = options(new PasswordOptions());
    }
    
    public void Check(string password)
    {
        if (password.Length < _options.Min || password.Length > _options.Max)
        {
            throw  new ArgumentOutOfRangeException($"Password is too small or too long. Min lenght is {_options.Min}, max lenght is {_options.Max}!");
        }

        if (_options.HasDigit && !password.Any(char.IsDigit))
        {
            throw new FormatException("Password has no digit!");
        }
        if (_options.HasUpper && !password.Any(char.IsUpper))
        {
            throw new FormatException("Password has no upper letter!");
        }
        if (_options.HasSpecial && password.All(c => char.IsAsciiLetterOrDigit(c)))
        {
            throw new FormatException("Password has no special character!");
        }
        
    }
}