using System;
class PasswordCracker
{
    static void Main()
    {
        char[] chars = { 'a', 'b', 'c' };
        string password = "aba";
        int length = password.Length;
        PasswordCracker obj = new PasswordCracker();
        bool result = obj.Crack("", chars, length, password);
    }
    bool Crack(string current, char[] chars, int length, string password)
    {
        if (current.Length == length)
        {
            Console.WriteLine("Trying: " + current);
            if (current == password)
            {
                System.Console.WriteLine("Password Matched: " + current);
                return true;
            }
            return false;
        }
        foreach (char c in chars)
        {
            if (Crack(current + c, chars, length, password))
            {
                return true;
            }
        }
        return false;
    }
}