using System;
using System.Text.RegularExpressions;

class HexCode
{
    static void Main()
    {
        Console.Write("Enter hex color code: ");
        string color = Console.ReadLine();

        // Regex pattern explanation:
        // ^        → Start of the string
        // #        → Matches the '#' symbol
        // [0-9]    → Matches digits from 0 to 9
        // [A-F]    → Matches uppercase letters A to F
        // [a-f]    → Matches lowercase letters a to f
        // {6}      → Exactly 6 hexadecimal characters
        // $        → End of the string
        string pattern = @"^#[0-9A-Fa-f]{6}$";

        if (Regex.IsMatch(color, pattern))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}
