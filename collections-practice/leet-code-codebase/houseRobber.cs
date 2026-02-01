// 29-1-26
// LC-198
using System;

public class Solution
{
    public int Rob(int[] nums)
    {
        int ans = SpaceO(nums);
        return ans;
    }

    private int SpaceO(int[] nums)
    {
        int n = nums.Length;

        if (n == 0) return 0;
        if (n == 1) return nums[0];

        int next = 0;
        int prev = nums[n - 1];
        int curr = 0;

        for (int i = n - 2; i >= 0; i--)
        {
            int temp = next;

            int loot = nums[i] + temp;
            int noLoot = prev;

            curr = Math.Max(loot, noLoot);
            next = prev;
            prev = curr;
        }

        return prev;
    }
}
