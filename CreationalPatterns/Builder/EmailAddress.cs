namespace CreationalPatterns.Builder;

public class EmailAddress
{
    public string Address { get; }

    private EmailAddress(string address)
    {
        Address = address;
    }


    public static EmailAddress Of(string address)
    {
        if (!CheckEmail(address))
        {
            throw new ArgumentException("Invalid email address.");
        }
        return new EmailAddress(address);
    }


    private static bool CheckEmail(string address)
    {
        if (!address.Contains("@") || !address.Contains("."))
        {
            return false;
        }

        return true;
    }
}