using System;
using System.Text;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();

        StringBuilder ans = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                ans.Append(char.ToLower(c));
            }
        }

        string ans1 = ans.ToString();

        // Reverse the StringBuilder
        StringBuilder rev = new StringBuilder(ans1);
        char[] arr = ans1.ToCharArray();
        Array.Reverse(arr);
        string reverse = new string(arr);

        return ans1.Equals(reverse);
    }
}
