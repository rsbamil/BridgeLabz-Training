using System;
class MissingPositiveInteger
{
    static void Main()
    {
        MissingPositiveInteger obj = new MissingPositiveInteger();
        int[] arr = obj.Input();
        int missingPositive = obj.FindFirstMissingPositive(arr);
        Console.WriteLine("Enter target number to search");
        int target = int.Parse(Console.ReadLine());
        int index = obj.BinarySearch(arr, target);
        Console.WriteLine("The first missing positive integer is: " + missingPositive);
        if (target != -1)
        {
            Console.WriteLine("The index of target " + target + " is: " + index);
        }
        else
        {
            Console.WriteLine("Target not provided for binary search.");
        }
    }
    int[] Input()
    {
        Console.WriteLine("Enter size of array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    int FindFirstMissingPositive(int[] arr)
    {
        Array.Sort(arr);
        int targetIndex = 1;
        foreach (int num in arr)
        {
            if (num == targetIndex)
            {
                targetIndex++;
            }
        }
        return targetIndex;
    }
    int BinarySearch(int[] arr, int target)
    {
        Array.Sort(arr);
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; // Target not found
    }
}