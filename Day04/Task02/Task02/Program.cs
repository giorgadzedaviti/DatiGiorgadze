using System;

public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("is not allowed.");
            return double.NaN; 
        }

        return a / b;
    }
}

class Program
{
    static void Main()
    {
        double num = 4;
        double num1 = 2;

        double sum = Calculator.Add(num, num1);
        double difference = Calculator.Subtract(num, num1);
        double product = Calculator.Multiply(num, num1);
        double quotient = Calculator.Divide(num, num1);

        Console.WriteLine($"Addition: {num} + {num1} = {sum}");
        Console.WriteLine($"Subtraction: {num} - {num1} = {difference}");
        Console.WriteLine($"Multiplication: {num} * {num1} = {product}");
        Console.WriteLine($"Division: {num} / {num1} = {quotient}");
    }
}












































