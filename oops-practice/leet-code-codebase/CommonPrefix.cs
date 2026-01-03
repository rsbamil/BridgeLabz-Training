using System;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // Edge case
        if (strs.Length == 0)
            return "";

        Array.Sort(strs);   // Same as Arrays.sort()

        string start = strs[0];
        string end = strs[strs.Length - 1];

        int count = 0;

        for (int i = 0; i < start.Length; i++)
        {
            if (i < end.Length && start[i] == end[i])
            {
                count++;
            }
            else
            {
                break;
            }
        }

        return start.Substring(0, count);
    }
}
