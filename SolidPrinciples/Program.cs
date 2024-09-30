using SolidPrinciples.LiskovPrinciple;
using SolidPrinciples.OpenClosePrinciple;

namespace SolidPrinciples;

public abstract class Program
{
    static void Main(string[] args)
    {
        List<string> names = ["Adam", "Ewa", "Ela", "Karol"];
        LiskovDemo.Run();
    }
}