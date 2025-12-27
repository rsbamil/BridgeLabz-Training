using System;

class Palindrome
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string rev = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }

        if (str.Equals(rev))
            Console.WriteLine("It is a Palindrome String");
        else
            Console.WriteLine("It is NOT a Palindrome String");
    }
}
