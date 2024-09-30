using System;
namespace SolidPrinciples.OpenClosePrinciple;

public interface IOperator
{
    double Process(double a, double b);
}

public class AddOperator: IOperator{
    public double Process(double a, double b)
    {
        return a + b;
    }
}

public class SubOperator : IOperator
{
    public double Process(double a, double b)
    {
        return a - b;
    }
}


public class MulOperator : IOperator
{
    public double Process(double a, double b)
    {
        return a * b;
    }
}

public class DivOperator : IOperator
{
    public double Process(double a, double b)
    {
        return a / b;
    }
}

class OpenCloseCalculator
{
    public double Operand1 { get; set; }
    public double Operand2 { get; set; }
    public IOperator Operator { get; set; }

    public double Calculate()
    {
        return Operator.Process(Operand1, Operand2);
    }
}

public class OpenCloseDemo
{
    public static void Run()
    {
        OpenCloseCalculator calculator = new OpenCloseCalculator()
        {
            Operand1 = 5,
            Operand2 = 2,
            Operator = new AddOperator(),
        };
        Console.WriteLine(calculator.Calculate());
    }
}