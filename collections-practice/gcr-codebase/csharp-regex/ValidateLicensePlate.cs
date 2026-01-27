using System;
using System.Text.RegularExpressions;

class ValidateLicensePlate
{
    static void Main()
    {
        Console.Write("Enter license plate number: ");
        string plate = Console.ReadLine();

        string pattern = @"^[A-Z]{2}[0-9]{4}$";

        if (Regex.IsMatch(plate, pattern))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}
