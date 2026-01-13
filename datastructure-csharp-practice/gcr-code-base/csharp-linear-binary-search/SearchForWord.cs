using System;
class SearchForWord
{
    static void Main()
    {
        SearchForWord obj = new SearchForWord();
        string[] sentences = obj.Input();
        Console.WriteLine("Enter the word to search for:");
        string word = Console.ReadLine();
        obj.LinearSearch(sentences, word);
    }
    string[] Input()
    {
        Console.WriteLine("Enter the number of sentences:");
        int size = int.Parse(Console.ReadLine());
        string[] sentences = new string[size];
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < size; i++)
        {
            sentences[i] = Console.ReadLine();
        }
        return sentences;
    }
    void LinearSearch(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word))
            {
                Console.WriteLine("First sentence containing the word \"" + word + "\": " + sentences[i]);
                return;
            }
        }
        Console.WriteLine("No sentence found containing the word \"" + word + "\".");
    }
}