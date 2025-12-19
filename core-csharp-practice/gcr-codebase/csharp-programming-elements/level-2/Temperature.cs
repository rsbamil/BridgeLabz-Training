using System;

class Temperature
{
    static void Main(string[] args)
    {
        double celsius  = Convert.ToDouble(Console.ReadLine());
        double fahrenheitResult  = (celsius  * 9 / 5) + 32;
        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");
    }
}
