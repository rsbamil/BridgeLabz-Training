using System;
class SortBooks
{
    static void Main()
    {
        SortBooks obj = new SortBooks();
        int[] booksPrice = obj.Input();
        obj.MergeSort(booksPrice, 0, booksPrice.Length - 1);
        Console.WriteLine("SORTED BOOK PRICES IN ASCENDING ORDER :");
        for (int i = 0; i < booksPrice.Length; i++)
        {
            Console.Write(booksPrice[i] + " ");
        }
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF BOOKS:");
        int numberOfBooks = int.Parse(Console.ReadLine());
        int[] prices = new int[numberOfBooks];
        Console.WriteLine("ENTER THE PRICES OF THE BOOKS:");
        for (int i = 0; i < numberOfBooks; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }
        return prices;
    }
    void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }
    void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for (int i = 0; i < n1; i++)
        {
            L[i] = prices[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            R[j] = prices[mid + 1 + j];
        }
        int iIdx = 0;
        int jIdx = 0;
        int k = left;
        while (iIdx < n1 && jIdx < n2)
        {
            if (L[iIdx] <= R[jIdx])
            {
                prices[k++] = L[iIdx++];
            }
            else
            {
                prices[k++] = R[jIdx++];
            }
        }
        while (iIdx < n1)
        {
            prices[k++] = L[iIdx++];
        }
        while (jIdx < n2)
        {
            prices[k++] = R[jIdx++];
        }
    }
}