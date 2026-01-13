using System;
class RotationPoint
{
    static void Main()
    {
        RotationPoint obj = new RotationPoint();
        int[] arr = obj.Input();
        int result = obj.FindRotationPoint(arr);
        Console.WriteLine("The index of the smallest element (rotation point) is: " + result);
    }
    int[] Input()
    {
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the rotated sorted array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    int FindRotationPoint(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left; // The index of the smallest element
    }
}