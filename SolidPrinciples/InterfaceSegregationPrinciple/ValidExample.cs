namespace SolidPrinciples.InterfaceSegregationPrinciple;

public interface IPrinter
{
    void Print(string text);
}

public interface IScanner
{
    string Scan();
}

public interface ICopier : IPrinter, IScanner
{
    void Copy(int copyNumber)
    {
        for (int i = 0; i < copyNumber; i++)
        {
            Print(Scan());
        }
    }
}