using System;
using System.Collections.Generic;

class EduResults
{
    static void Main()
    {
        // Each district submits a sorted list of marks
        int[] district1 = { 95, 88, 76 };
        int[] district2 = { 98, 90, 70 };
        int[] district3 = { 92, 88, 80 };

        // Merge all district data into one list
        List<int> allMarks = new List<int>();
        allMarks.AddRange(district1);
        allMarks.AddRange(district2);
        allMarks.AddRange(district3);

        int[] marksArray = allMarks.ToArray();

        // Apply Merge Sort
        MergeSort(marksArray, 0, marksArray.Length - 1);

        Console.WriteLine("Final State-wise Rank List (Descending):");
        for (int i = marksArray.Length - 1; i >= 0; i--)
        {
            Console.Write(marksArray[i] + " ");
        }
    }

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

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        // Stable merge
        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
                arr[k++] = L[iIndex++];
            else
                arr[k++] = R[jIndex++];
        }

        while (iIndex < n1)
            arr[k++] = L[iIndex++];

        while (jIndex < n2)
            arr[k++] = R[jIndex++];
    }
}
