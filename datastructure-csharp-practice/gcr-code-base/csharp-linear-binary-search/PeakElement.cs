using System;
class PeakElement
{
    static void Main()
    {
        PeakElement obj = new PeakElement();
        int[] arr = obj.Input();
        int result = obj.FindPeakElement(arr);
        Console.WriteLine("A peak element is: " + result);
    }
    int[] Input()
    {
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    int FindPeakElement(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return arr[left]; // A peak element
    }
}