using System;

class PowerCalculation
{
    static int Pow(int a, int b)
    {
        if (b == 0)
            return 1;
        return a * Pow(a, b - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the base number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = Pow(a, b);
        Console.WriteLine("Result: " + result);
    }
}
