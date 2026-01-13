using System;
using System.Text;
class ConcatenateStrings
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the string array: ");
        int size = int.Parse(Console.ReadLine());
        string[] strings = new string[size];
        for (int i = 0; i < size; i++)
        {
            strings[i] = Console.ReadLine();
        }
        StringBuilder result = new StringBuilder();
        foreach (string str in strings)
        {
            result.Append(str);
            result.Append(" ");
        }
        Console.WriteLine("Concatenated string: " + result.ToString());
    }
}