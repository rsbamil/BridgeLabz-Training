using System;

class RemoveChar
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char ch = Console.ReadLine()[0];

        string ans = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ch)
            {
                ans += s[i];
            }
        }

        Console.WriteLine("Modified String: " + ans);
    }
}
