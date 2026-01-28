using System;

class Temperature2
{
    static void Main(string[] args)
    {
        double fahrenheit  = Convert.ToDouble(Console.ReadLine());
        double celsiusResult  = (fahrenheit - 32) * 5/9;
        Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsiusResult+" Celsius");
    }
}
