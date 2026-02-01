// 29-1-26
// LC-322
using System;

public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        Array.Fill(dp, -1);

        int ans = TopDown(coins, amount, dp);
        return ans == int.MaxValue ? -1 : ans;
    }

    private int TopDown(int[] coins, int amt, int[] dp)
    {
        if (amt == 0)
            return 0;

        if (dp[amt] != -1)
            return dp[amt];

        int mini = int.MaxValue;

        for (int i = 0; i < coins.Length; i++)
        {
            if (amt - coins[i] >= 0)
            {
                int recAns = TopDown(coins, amt - coins[i], dp);

                if (recAns != int.MaxValue)
                {
                    int ans = 1 + recAns;
                    mini = Math.Min(mini, ans);
                }
            }
        }

        dp[amt] = mini;
        return dp[amt];
    }
}
