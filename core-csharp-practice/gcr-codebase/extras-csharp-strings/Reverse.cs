using System;

class Reverse
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string reversed = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }

        Console.WriteLine("Reversed String: " + reversed);
    }
}
