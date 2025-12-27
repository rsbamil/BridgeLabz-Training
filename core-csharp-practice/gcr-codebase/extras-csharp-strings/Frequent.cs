using System;

class Frequent
{
    static void Main()
    {
        Console.Write("Enter a sing: ");
        string s = Console.ReadLine();

        int[] freq = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            freq[s[i]]++;
        }

        char mostChar = s[0];
        int max = freq[s[0]];

        for (int i = 1; i < s.Length; i++)
        {
            if (freq[s[i]] > max)
            {
                max = freq[s[i]];
                mostChar = s[i];
            }
        }

        Console.WriteLine("Most Frequent Character: '" + mostChar + "'");
    }
}
