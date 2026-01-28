using System;

interface IWord
{
    void AddWord(string word);
    void DisplayWord(char firstLetter);
    void SortWords();
}
abstract class Free
{
    public void Show()
    {
        Console.WriteLine(name);
    }

};
class DictionaryImpl : IWord
{
    string[] words;
    int size;
    int countWords = 0;
    public int Size
    {
        get { return size; }
        set
        {
            size = value;
            words = new string[size];
        }
    }
    public void AddWord(string word)
    {
        if (countWords < size)
        {
            words[countWords++] = word;
            Console.WriteLine("Added a word: " + word);
        }
        else
        {
            Console.WriteLine("Storage is full");
        }
    }
    public void DisplayWord(char firstLetter)
    {
        Console.WriteLine("\nWORDS STARTING WITH LETTER: " + firstLetter);

        for (int i = 0; i < countWords; i++)
        {
            if (words[i][0] == firstLetter)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
    public void SortWords()
    {
        for (int i = 0; i < countWords; i++)
        {
            for (int j = i + 1; j < countWords; j++)
            {
                if (string.Compare(words[i], words[j]) > 0)
                {
                    string temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted words");
        for (int i = 0; i < countWords; i++)
        {
            Console.Write(words[i] + " ");
        }
    }
}
class DictionaryForm
{
    static void Main()
    {
        
        int size = int.Parse(Console.ReadLine());

        DictionaryImpl dict = new DictionaryImpl();

        dict.Size = size;

        while (true)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. ADD WORD");
            Console.WriteLine("2. DISPLAY WORDS BY FIRST LETTER");

        }
    }
}
