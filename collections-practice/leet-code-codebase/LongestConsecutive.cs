// 22-1-26
// LC 128
using System;
using System.Collections.Generic;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        return Consecutive_Sequence(nums);
    }

    public static int Consecutive_Sequence(int[] nums)
    {
        Dictionary<int, bool> map = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i] - 1))
            {
                map[nums[i]] = false;
            }
            else
            {
                map[nums[i]] = true;
            }

            if (map.ContainsKey(nums[i] + 1))
            {
                map[nums[i] + 1] = false;
            }
        }

        int ans = 0;

        foreach (int key in map.Keys)
        {
            if (map[key])
            {
                int count = 0;
                int curr = key;

                while (map.ContainsKey(curr))
                {
                    count++;
                    curr++;
                }

                ans = Math.Max(ans, count);
            }
        }

        return ans;
    }
}
