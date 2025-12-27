using System;

class Longest
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string s = Console.ReadLine();

        string[] words = s.Split(' ');

        string longWord = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longWord.Length)
            {
                longWord = words[i];
            }
        }

        Console.WriteLine("Longest Word: " + longWord);
    }
}
