using System;

class UpperCase
{
    static void Main()
    {
        string s = Console.ReadLine();
        string ans1 = ConvertToUpper(s);
        string ans2 = s.ToUpper();
        Console.WriteLine("Original s : " + s);
        Console.WriteLine("Manual Upper  : " + ans1);
        Console.WriteLine("Built-in Upper: " + ans2);
    }
    static string ConvertToUpper(string s)
    {
        char[] chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                chars[i] = (char)(chars[i] - 32);
            }
        }
        return new string(chars);
    }
}
