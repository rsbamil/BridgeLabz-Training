using System;
using System.IO;
class CountTheOccurrence
{
    static void Main()
    {
        string filePath = "sample.txt";
        Console.WriteLine("Enter the word to find its occurrence:");
        string wordToFind = Console.ReadLine();
        int count = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', '?', '\n', '.', ',');
                    foreach (string word in words)
                    {
                        if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine("The occurrence of the word '" + wordToFind + "' is: " + count);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}