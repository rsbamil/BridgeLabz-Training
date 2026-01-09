using System;
using System.Collections.Generic;

class TwoSum
{
    static void FindIndices(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (map.ContainsKey(diff))
            {
                Console.WriteLine(map[diff] + " , " + i);
                return;
            }

            map[nums[i]] = i;
        }
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter target sum: ");
        int target = int.Parse(Console.ReadLine());
        FindIndices(arr, target);
    }
}