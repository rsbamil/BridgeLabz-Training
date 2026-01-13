using System;
class SearchTarget
{
    static void Main()
    {
        SearchTarget obj = new SearchTarget();
        int[,] arr = obj.Input();
        Console.WriteLine("Enter the target value to search for:");
        int target = int.Parse(Console.ReadLine());
        bool found = obj.BinarySearch(arr, target);
        if (found)
        {
            Console.WriteLine("Target value " + target + " found in the matrix.");
        }
        else
        {
            Console.WriteLine("Target value " + target + " not found in the matrix.");
        }
    }
    int[,] Input()
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns:");
        int cols = int.Parse(Console.ReadLine());
        int[,] arr = new int[rows, cols];
        Console.WriteLine("Enter the elements of the matrix row-wise:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return arr;
    }
    bool BinarySearch(int[,] arr, int target)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int left = 0;
        int right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = arr[mid / cols, mid % cols];

            if (midValue == target)
            {
                return true; // Target found
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false; // Target not found
    }
}