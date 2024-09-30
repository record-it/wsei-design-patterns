namespace CreationalPatterns.Options;

public class PasswordDemo
{
    public static void Run()
    {
        PasswordChecker checker = new PasswordChecker(
            new PasswordOptions()
            {
                Min = 6,
                Max = 10,
                HasDigit = true,
                HasUpper = true
            }
        );

        checker.Check("alibaba");
        Console.WriteLine("Password is valid!");
    }
}