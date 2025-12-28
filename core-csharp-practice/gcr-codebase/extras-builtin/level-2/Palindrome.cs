using System;

class Palindrome
{
    static void Main()
    {
        string text = Console.ReadLine();
        bool result = IsPalindrome(text);
        if (result){
            Console.WriteLine("\"" + text + "\" is a Palindrome");
     }
        else{
            Console.WriteLine("\"" + text + "\" is NOT a Palindrome");
        }
    }

    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (Char.ToLower(str[left]) != Char.ToLower(str[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
