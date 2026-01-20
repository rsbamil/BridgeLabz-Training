using System;
class AadharNumberSort
{
    static void Main()
    {
        AadharNumberSort obj = new AadharNumberSort();
        int[] arr = obj.Input();
        obj.RadixSort(arr);
        Console.WriteLine("Sorted Aadhar Number: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
    int[] Input()
    {
        int[] arr = new int[12];
        Console.WriteLine("Enter 12 digit Aadhar Number: ");
        for (int i = 0; i < 12; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    void RadixSort(int[] arr)
    {
        int maxElem = GetMax(arr);
        for (int exp = 1; maxElem / exp > 0; exp *= 10)
        {
            CountingSort(arr, exp);
        }
    }
    int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
    void CountingSort(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];
        for (int i = 0; i < n; i++)
        {
            count[(arr[i] / exp) % 10]++;  // counting frequency
        }
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];  // building cumulative sum
        }
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = arr[i] / exp % 10;
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }
}