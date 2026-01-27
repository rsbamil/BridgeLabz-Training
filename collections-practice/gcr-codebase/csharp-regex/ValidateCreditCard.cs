using System;
using System.Text.RegularExpressions;
class ValidateCreditCard
{
    static void Main()
    {
        string card = "4111111111111111";
        bool valid = Regex.IsMatch(card, @"^(4\d{15}|5\d{15})$");

        Console.WriteLine(valid ? "Valid Card" : "Invalid Card");
    }
}