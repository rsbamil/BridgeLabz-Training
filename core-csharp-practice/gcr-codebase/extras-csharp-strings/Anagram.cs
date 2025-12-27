using System;

class Anagram
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] freq = new int[256];

        for (int i = 0; i < s1.Length; i++)
        {
            freq[s1[i]]++;
            freq[s2[i]]--;
        }

        bool flag = true;

        for (int i = 0; i < 256; i++)
        {
            if (freq[i] != 0)
            {
                flag = false;
                break;
            }
        }

        if (flag)
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}
