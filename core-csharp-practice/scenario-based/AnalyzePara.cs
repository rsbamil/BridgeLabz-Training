using System;
class AnalyzePara
{
    static void Main()
    {
        // Input paragraph from user
        Console.WriteLine("Enter a paragraph:");
        string sentence = Console.ReadLine();
        // Checking Empty Paragraph and Paragraph with only spaces without built in functions
        bool isEmpty = true;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                isEmpty = false;
                break;
            }
        }
        if (isEmpty)
        {
            Console.WriteLine("The paragraph is empty or contains only spaces.");
            return;
        }
        string result = AnalyzeParagraph(sentence); // Call the method to analyze the paragraph
        Console.WriteLine("Analyzed Paragraph: " + result);
    }
    static string AnalyzeParagraph(string sentence)
    {
        // Display options to the user
        Console.WriteLine("Choose Options: ");
        Console.WriteLine("1. Count the number of words in a paragraph.");
        Console.WriteLine("2. Find and display the longest word in the paragraph.");
        Console.WriteLine("3. Replace all occurrences of a specific word with another word (case-insensitive).");
        switch (Console.ReadLine())
        {
            case "1":
                return CountWords(sentence);
            case "2":
                return FindLongestWord(sentence);
            case "3":
                return ReplaceWord(sentence);
            default:
                return "Invalid Option Selected.";
        }
    }
    static string CountWords(string sentence)
    {
        int count=0;
        bool isWord=false;
        for(int i = 0; i < sentence.Length; i++)
        {
            if(sentence[i]!=' ' && !isWord)
            {
                count++;
                isWord=true;
            }
            else if(sentence[i]==' ')
            {
                isWord=false;
            }
        }
        return "Number of words in the paragraph: "+count;
    }
    static string FindLongestWord(string sentence)
    {
        // Finding the longest word
        string [] arr=sentence.Trim().Split();  // Splitting the sentence into words
        int longest=arr[0].Length;
        int idx=0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > longest)
            {
                longest=arr[i].Length;
                idx=i;
            }
        }
        return "Longest word in the paragraph: "+arr[idx];
    }
    static string ReplaceWord(string sentence)
    {
        Console.WriteLine("Enter the word to be replaced:");
        string oldWord=Console.ReadLine();
        Console.WriteLine("Enter the new word:");
        string newWord=Console.ReadLine();

        string [] arr=sentence.Trim().Split();
        string res="";
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(oldWord))
            {
                res+=newWord+" ";
            }
            else
            {
                res+=arr[i]+" ";
            }
        }
        return res;
    }
}