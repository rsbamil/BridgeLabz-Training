using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;


class FlipKey
{
    static void Main()
    {
        FlipKey obj = new FlipKey();
        string input = Console.ReadLine();
        string result = obj.CleanseAndInvert(input);
        Console.WriteLine(result);
    }
    public string CleanseAndInvert(string input)
    {
        if (input == null || input.Length <= 6)
        {
            return "Invalid Input";
        }
        string pattern = @"^[A-Za-z]+$";
        if (!Regex.IsMatch(input, pattern))
        {
            return "Invalid Input";
        }
        input = input.ToLower();
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
        {
            if ((int)c % 2 != 0)
            {
                sb.Append(c);
            }
        }
        string reversed = new string(sb.ToString().Reverse().ToArray());
        char[] result = reversed.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = char.ToUpper(result[i]);
            }
        }
        return new string(result);
    }
}