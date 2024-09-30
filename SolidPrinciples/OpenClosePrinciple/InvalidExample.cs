using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;

namespace SolidPrinciples.OpenClosePrinciple;

public enum Operator
{
    Add,
    Sub,
    Mul,
    Div
}

class Calculator
{
    public double Operand1 { get; set; }
    public double Operand2 { get; set; }
    public Operator Operator { get; set; }

    double Calculate(Operator op)
    {
        switch (Operator)
        {
            case Operator.Add:
                return Operand1 + Operand2;
            case Operator.Sub:
                return Operand1 - Operand2;
            case Operator.Mul:
                return Operand1 * Operand2;
            case Operator.Div:
                return Math.Pow(Operand1, Operand2);
        }
        return Double.NaN;
    }
}