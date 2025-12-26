using System;

class LowerCase
{
    static void Main()
    {
        string s = Console.ReadLine();
        string ans1 = ToLowerCase(s);
        string ans2 = s.ToLower();
        Console.WriteLine("Original string : " + s);
        Console.WriteLine("Manual Lower  : " + ans1);
        Console.WriteLine("Built-in Lower: " + ans2);
    }
    static string ToLowerCase(string input)
    {
        char[] letters = input.ToCharArray();

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] >= 'A' && letters[i] <= 'Z')
            {
                letters[i] = (char)(letters[i] + 32);
            }
        }
        return new string(letters);
    }
}
