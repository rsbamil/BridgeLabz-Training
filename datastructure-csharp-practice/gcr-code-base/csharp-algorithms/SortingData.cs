using System;
using System.Diagnostics;

class SortingData
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int size in sizes)
        {
            Console.WriteLine("\nDataset Size: " + size);

            int[] original = GenerateArray(size);

            // Bubble Sort (skip for very large data)
            if (size <= 10000)
            {
                int[] bubbleArr = (int[])original.Clone();
                MeasureTime("Bubble Sort", () => BubbleSort(bubbleArr));
            }
            else
            {
                Console.WriteLine("Bubble Sort skipped for size " + size);
            }

            // Merge Sort
            int[] mergeArr = (int[])original.Clone();
            MeasureTime("Merge Sort", () => MergeSort(mergeArr, 0, mergeArr.Length - 1));

            // Quick Sort
            int[] quickArr = (int[])original.Clone();
            MeasureTime("Quick Sort", () => QuickSort(quickArr, 0, quickArr.Length - 1));
        }
    }

    // 🔹 Utility: Generate Random Array
    static int[] GenerateArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(1, size);
        return arr;
    }

    // 🔹 Utility: Measure Execution Time
    static void MeasureTime(string name, Action sortMethod)
    {
        Stopwatch sw = Stopwatch.StartNew();
        sortMethod();
        sw.Stop();
        Console.WriteLine(name + " " + sw.ElapsedMilliseconds + " ms");
    }

    // 🔹 Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // 🔹 Merge Sort
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
            arr[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];

        while (i < n1)
            arr[k++] = L[i++];

        while (j < n2)
            arr[k++] = R[j++];
    }

    // 🔹 Quick Sort
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
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

        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;

        return i + 1;
    }
}
