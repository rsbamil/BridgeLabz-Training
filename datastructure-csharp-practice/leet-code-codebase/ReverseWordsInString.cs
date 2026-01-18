// 17-01-2026
// LC - 151
using System;

public class Solution
{
    public string ReverseWords(string s)
    {
        // Trim leading and trailing spaces
        s = s.Trim();

        // Split by one or more spaces
        string[] words = s.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        // Reverse the array in-place
        int left = 0, right = words.Length - 1;
        while (left < right)
        {
            string temp = words[left];
            words[left] = words[right];
            words[right] = temp;
            left++;
            right--;
        }

        // Join with single space
        return string.Join(" ", words);
    }
}
