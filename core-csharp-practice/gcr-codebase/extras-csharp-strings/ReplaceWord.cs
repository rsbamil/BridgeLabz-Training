using System;

class ReplaceWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string s = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string old = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string[] words = s.Split(' ');
        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(old))
                result += newWord;
            else
                result += words[i];

            if (i < words.Length - 1)
                result += " ";
        }

        Console.WriteLine("Modified Sentence: " + result);
    }
}
