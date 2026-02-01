// 27-1-26
// LC-42

using System;

public class Solution
{
    public int Trap(int[] height)
    {
        int n = height.Length;

        int[] leftMax = GetLeftMax(height, n);
        int[] rightMax = GetRightMax(height, n);

        int ans = 0;

        for (int i = 0; i < n; i++)
        {
            int h = Math.Min(leftMax[i], rightMax[i]) - height[i];
            ans += h;
        }

        return ans;
    }

    public int[] GetLeftMax(int[] arr, int n)
    {
        int[] left = new int[n];
        left[0] = arr[0];

        for (int i = 1; i < n; i++)
        {
            left[i] = Math.Max(left[i - 1], arr[i]);
        }

        return left;
    }

    public int[] GetRightMax(int[] arr, int n)
    {
        int[] right = new int[n];
        right[n - 1] = arr[n - 1];

        for (int i = n - 2; i >= 0; i--)
        {
            right[i] = Math.Max(right[i + 1], arr[i]);
        }

        return right;
    }
}
