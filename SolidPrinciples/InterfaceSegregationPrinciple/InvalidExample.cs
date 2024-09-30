namespace SolidPrinciples.InterfaceSegregationPrinciple;

public interface Copier
{
    void CopyPage(int copyNumber);
    void PrintPage(string text);
    string ScanPage();
}

public class Printer : Copier
{
    public void CopyPage(int copyNumber)
    {
        throw new NotImplementedException();
    }

    public void PrintPage(string text)
    {
        Console.WriteLine("Page printed");
    }

    public string ScanPage()
    {
        throw new NotImplementedException();
    }
}

public class Scanner : Copier
{
    public void CopyPage(int copyNumber)
    {
        throw new NotImplementedException();
    }

    public void PrintPage(string text)
    {
        throw new NotImplementedException();
    }

    public string ScanPage()
    {
        Console.WriteLine("Page scanned");
        return "Scanned page";
    }
}