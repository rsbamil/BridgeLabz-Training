using System;

class PowerCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int b = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(a, b);
        Console.WriteLine("Result: " + result);
    }
}
