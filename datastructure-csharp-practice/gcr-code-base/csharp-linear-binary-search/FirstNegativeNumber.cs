using System;
class FirstNegativeNumber
{
    static void Main()
    {
        FirstNegativeNumber obj = new FirstNegativeNumber();
        int[] arr = obj.Input();
        int result = obj.LinearSearch(arr);
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
    int LinearSearch(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("First negative number is: " + arr[i]);
                return arr[i];
            }
        }
        Console.WriteLine("No negative number found in the array.");
        return -1; // Indicating no negative number found
    }
}