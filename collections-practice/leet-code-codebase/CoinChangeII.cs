// 30-1-26
// LC-518
using System;

public class Solution
{
    public int Change(int amount, int[] coins)
    {
        return Fun(coins, amount);
    }

    private int Fun(int[] coins, int amount)
    {
        int[,] dp = new int[coins.Length + 1, amount + 1];

        // Base case: amount = 0 → 1 way (choose nothing)
        for (int i = 0; i <= coins.Length; i++)
        {
            dp[i, 0] = 1;
        }

        for (int c = 1; c <= coins.Length; c++)
        {
            for (int am = 1; am <= amount; am++)
            {
                int inc = 0;
                int exc = 0;

                if (am >= coins[c - 1])
                {
                    inc = dp[c, am - coins[c - 1]];
                }

                exc = dp[c - 1, am];
                dp[c, am] = inc + exc;
            }
        }

        return dp[coins.Length, amount];
    }
}

