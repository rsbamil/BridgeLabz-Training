using System;
using System.Collections.Generic;

class Solution{
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int diff = target - nums[i];

            if (map.ContainsKey(diff)){
                return new int[] { map[diff], i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}
