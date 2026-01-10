using System;
class SortProductPrices
{
    static void Main()
    {
        SortProductPrices obj = new SortProductPrices();
        int[] productPrices = obj.Input();
        obj.QuickSort(productPrices, 0, productPrices.Length - 1);
        Console.WriteLine("SORTED PRODUCT PRICES IN ASCENDING ORDER :");
        for (int i = 0; i < productPrices.Length; i++)
        {
            Console.Write(productPrices[i] + " ");
        }
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF PRODUCTS:");
        int numberOfProducts = int.Parse(Console.ReadLine());
        int[] prices = new int[numberOfProducts];
        Console.WriteLine("ENTER THE PRICES OF THE PRODUCTS:");
        for (int i = 0; i < numberOfProducts; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }
        return prices;
    }
    void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(prices, low, high);
            QuickSort(prices, low, pi - 1);
            QuickSort(prices, pi + 1, high);
        }
        else
        {
            if (low == 0 && high == prices.Length - 1)
            {
                Console.WriteLine("SORTED PRODUCT PRICES IN ASCENDING ORDER :");
                for (int i = 0; i < prices.Length; i++)
                {
                    Console.Write(prices[i] + " ");
                }
            }
        }
    }
    int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }
        int temp1 = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = temp1;
        return i + 1;
    }
}