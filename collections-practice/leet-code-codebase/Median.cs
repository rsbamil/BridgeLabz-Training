// 28-1-26
// LC-4
using System;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int l1 = nums1.Length;
        int l2 = nums2.Length;

        int[] arr = new int[l1 + l2];
        int idx = 0;

        for (int i = 0; i < l1; i++)
        {
            arr[idx++] = nums1[i];
        }

        for (int i = 0; i < l2; i++)
        {
            arr[idx++] = nums2[i];
        }

        Array.Sort(arr);

        int l3 = arr.Length;

        if ((l3 & 1) == 1)
        {
            return (double)arr[l3 / 2];
        }

        int mid1 = arr[l3 / 2 - 1];
        int mid2 = arr[l3 / 2];

        return (mid1 + mid2) / 2.0;
    }
}
