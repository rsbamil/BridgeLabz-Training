using System;
class FirstLastOccur
{
    static void Main()
    {
        FirstLastOccur obj = new FirstLastOccur();
        int[] arr = obj.Input();
        Console.WriteLine("Enter the target element to search for:");
        int target = int.Parse(Console.ReadLine());
        int firstIndex = obj.FindFirstOccurrence(arr, target);
        int lastIndex = obj.FindLastOccurrence(arr, target);
        if (firstIndex != -1 && lastIndex != -1)
        {
            Console.WriteLine("First occurrence of " + target + " is at index: " + firstIndex);
            Console.WriteLine("Last occurrence of " + target + " is at index: " + lastIndex);
        }
        else
        {
            Console.WriteLine("Element " + target + " not found in the array.");
        }
    }
    int[] Input()
    {
        Console.WriteLine("Enter the size of the sorted array:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the sorted array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int firstIndex = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                firstIndex = mid;
                right = mid - 1; // Continue searching in the left half
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
        return firstIndex;
    }
    int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int lastIndex = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                lastIndex = mid;
                left = mid + 1; // Continue searching in the right half
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
        return lastIndex;
    }
}