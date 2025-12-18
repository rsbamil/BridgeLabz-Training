using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Enter principal amount: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (in years): ");
        int t = Convert.ToInt32(Console.ReadLine());

        double si = (p * r * t) / 100;
        Console.WriteLine("Simple Interest is " + si);
    }
}
