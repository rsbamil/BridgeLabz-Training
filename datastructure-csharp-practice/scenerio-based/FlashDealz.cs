using System;
class FlashDealz
{
    static void Main()
    {
        FlashDealz obj = new FlashDealz();
        int[] discount = obj.Input();
        obj.QuickSort(discount, 0, discount.Length - 1);
        Console.WriteLine("Sorted discount percentages:");
        foreach (int d in discount)
        {
            Console.Write(d + " ");
        }

    }
    int[] Input()
    {
        Console.WriteLine("Enter number of products:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] discounts = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            discounts[i] = rand.Next(1, 101);
        }
        return discounts;
    }
    void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }
    int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        return i + 1;
    }
}