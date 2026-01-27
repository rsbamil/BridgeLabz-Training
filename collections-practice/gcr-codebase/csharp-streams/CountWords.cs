using System;
using System.IO;
using System.Collections.Generic;

class CountWords
{
    static void Main()
    {
        string filePath = "Source.txt";

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line
                        .ToLower()
                        .Split(new char[] { ' ', '.', ',', ';', '!', '?' },
                               StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }

            // Convert dictionary to list for sorting
            List<KeyValuePair<string, int>> list =
                new List<KeyValuePair<string, int>>(wordCount);

            // Sort by frequency (descending)
            list.Sort((a, b) => b.Value.CompareTo(a.Value));

            Console.WriteLine("Top 5 most frequent words:\n");

            for (int i = 0; i < 5 && i < list.Count; i++)
            {
                Console.WriteLine(list[i].Key + " : " + list[i].Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
