namespace CreationalPatterns.Builder;

public class BuilderDemo
{
    public static void Run()
    {
        var emailMessage = EmailMessage.Builder()
            .Sender(EmailAddress.Of("sender@wsei.edu.pl"))
            .AddTo(EmailAddress.Of("target@wsei.edu.pl"))
            .AddCc(EmailAddress.Of("student@gmail.com"))
            .Subject("Test")
            .Build();
        Console.WriteLine("EmailMessage builder demo");
        Console.WriteLine(emailMessage);
        
    }
}