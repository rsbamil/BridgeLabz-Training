using System;

class TempConvert
{
    static void Main()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double result = CelsiusToFahrenheit(temp);
            Console.WriteLine("Temperature in Fahrenheit = " + result);
        }
        else if (choice == 2)
        {
            double result = FahrenheitToCelsius(temp);
            Console.WriteLine("Temperature in Celsius = " + result);
        }
        else
        {
            Console.WriteLine("Invalid Choice!");
        }
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
