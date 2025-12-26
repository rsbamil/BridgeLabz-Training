using System;
class AllCharacters
{
    static void Main()
    {
        string s = Console.ReadLine();
        char[] chars = s.ToCharArray();
        char[] chars2 = Characters(s);
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != chars2[i])
            {
                Console.WriteLine("Not Equal");
                return;
            }
        }
        Console.WriteLine("Equal");
    }
    static char[] Characters(string s)
    {
        char[] ans = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            ans[i] = s[i];
        }
        return ans;
    }
}