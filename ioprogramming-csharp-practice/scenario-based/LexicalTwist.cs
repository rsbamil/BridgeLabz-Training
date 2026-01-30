using System;
using System.Text;
using System.Collections.Generic;

class LexicalTwist
{
    static void Main()
    {
        Console.WriteLine("Enter the first word");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second word");
        string str2 = Console.ReadLine();

        if (str1.Contains(" "))
        {
            Console.WriteLine(str1 + " is an invalid word");
            return;
        }
        if (str2.Contains(" "))
        {
            Console.WriteLine(str2 + " is an invalid word");
            return;
        }

        if (string.Equals(str2, Reverse(str1), StringComparison.OrdinalIgnoreCase))
        {
            StringBuilder sb = new StringBuilder(Reverse(str1).ToLower());

            for (int i = 0; i < sb.Length; i++)
            {
                if (IsVowel(sb[i]))
                {
                    sb[i] = '@';
                }
            }

            Console.WriteLine(sb.ToString());
        }
        else
        {
            string combined = (str1 + str2).ToUpper();

            int vowelCount = 0;
            int consonantCount = 0;

            foreach (char c in combined)
            {
                if (IsVowel(c))
                    vowelCount++;
                else if (c >= 'A' && c <= 'Z')
                    consonantCount++;
            }

            if (vowelCount == consonantCount)
            {
                Console.WriteLine("Vowels and consonants are equal");
            }
            else if (vowelCount > consonantCount)
            {
                PrintFirstTwoUnique(combined, true);
            }
            else
            {
                PrintFirstTwoUnique(combined, false);
            }
        }
    }

    static string Reverse(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static bool IsVowel(char c)
    {
        return "AEIOUaeiou".IndexOf(c) != -1;
    }

    static void PrintFirstTwoUnique(string str, bool vowels)
    {
        HashSet<char> seen = new HashSet<char>();
        int count = 0;

        foreach (char c in str)
        {
            if (count == 2)
                break;

            if (vowels && IsVowel(c) && !seen.Contains(c))
            {
                Console.Write(c);
                seen.Add(c);
                count++;
            }
            else if (!vowels && !IsVowel(c) && c >= 'A' && c <= 'Z' && !seen.Contains(c))
            {
                Console.Write(c);
                seen.Add(c);
                count++;
            }
        }
        Console.WriteLine();
    }
}
