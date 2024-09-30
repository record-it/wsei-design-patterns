// See https://aka.ms/new-console-template for more information

using CreationalPatterns.Builder;
using CreationalPatterns.Options;

public class Program
{
    public static void Main(string[] args)
    {
        BuilderDemo.Run();
        //PasswordDemo.Run();
        PrototypeDemo.Run();
    }
}