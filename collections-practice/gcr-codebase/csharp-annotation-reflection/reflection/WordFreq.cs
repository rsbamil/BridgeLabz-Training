using System;
using System.Collections.Generic;
using System.IO;

class WordFreq
{
    static void Main()
    {
        string text = "Hello world, hello Java!";

        Dictionary<string, int> frequency = new Dictionary<string, int>();

        // Convert to lowercase and split words
        string[] words = text
            .ToLower()
            .Split(new char[] { ' ', ',', '!', '.', '?' },
                   StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        Console.WriteLine("Output:");
        foreach (var pair in frequency)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}
