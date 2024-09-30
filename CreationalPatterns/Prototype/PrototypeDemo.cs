

using CreationalPatterns.Prototype;

public class PrototypeDemo
{
    public static void Run()
    {
        Person first = new("Adam", "Jones", new DateTime(2000, 10, 10));
        Person second = first with { FirstName = "Karol" };
        Console.WriteLine(first);
        Console.WriteLine(second);
        
        Book originalBook = new Book(){Pages = 123, Title = "Old Book", Author = "Karol"};
        Book copyBook = (Book)originalBook.Clone();
        copyBook.Pages = 120;
        Console.WriteLine(originalBook);
        Console.WriteLine(copyBook);
    }
}