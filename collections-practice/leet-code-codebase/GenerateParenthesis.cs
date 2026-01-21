// 21-1-26
// LC 22
using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> ans = new List<string>();
        Fun(n, ans, 0, 0, "");
        return ans;
    }

    public static void Fun(int n, List<string> ans, int open, int close, string s)
    {
        if (open == n && close == open)
        {
            ans.Add(s);
            return;
        }

        if (open < n)
        {
            Fun(n, ans, open + 1, close, s + "(");
        }

        if (close < open)
        {
            Fun(n, ans, open, close + 1, s + ")");
        }
    }
}
