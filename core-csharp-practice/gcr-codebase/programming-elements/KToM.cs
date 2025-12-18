using System;

class KToM
{
    static void Main(string[] args)
    {
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = km * 0.621371;
        Console.WriteLine(miles);
    }
}
