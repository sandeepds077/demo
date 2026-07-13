using System;

var calculator = new Calculator();

Console.WriteLine("Simple .NET calculator demo");
Console.WriteLine("==========================");
Console.WriteLine($"Sum of 10 and 25: {calculator.Add(10, 25)}");
Console.WriteLine($"Difference of 50 and 18: {calculator.Subtract(50, 18)}");
Console.WriteLine($"Product of 6 and 7: {calculator.Multiply(6, 7)}");
Console.WriteLine($"Quotient of 81 and 9: {calculator.Divide(81, 9)}");

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }
}
