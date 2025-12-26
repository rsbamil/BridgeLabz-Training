using System;

class Split
{
    static void Main()
    {
        string s = Console.ReadLine();

        string[,] result = WordLength(s);
        int rows=result.GetLength(0);
        Console.WriteLine("Word\t\tLength");

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(result[i, 0] + "\t\t" + result[i, 1]);
        }
    }
    static string[,] WordLength(string text)
    {
        int wordCount = CountWords(text);
        string[,] data = new string[wordCount, 2];
        int row = 0;
        string currentWord = "";
        for (int i = 0; i < CountChars(text); i++)
        {
            char ch = text[i];
            if (ch != ' ')
            {
                currentWord += ch;
            }
            else
            {
                if (currentWord != "")
                {
                    data[row, 0] = currentWord;
                    data[row, 1] = CalculateLength(currentWord).ToString();
                    row++;
                    currentWord = "";
                }
            }
        }

        if (currentWord != "")
        {
            data[row, 0] = currentWord;
            data[row, 1] = CalculateLength(currentWord).ToString();
        }

        return data;
    }
    static int CountWords(string text)
    {
        int count = 0;
        bool insideWord = false;

        for (int i = 0; i < CountChars(text); i++)
        {
            if (text[i] != ' ' && !insideWord)
            {
                count++;
                insideWord = true;
            }
            else if (text[i] == ' ')
            {
                insideWord = false;
            }
        }
        return count;
    }

    static int CalculateLength(string value)
    {
        int length = 0;
        foreach (char c in value)
            length++;
        return length;
    }

    static int CountChars(string text)
    {
        int count = 0;
        foreach(char c in text){
            count++;
        }
        return count;
    }

}
