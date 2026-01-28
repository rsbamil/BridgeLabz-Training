using System;
using System.Collections.Generic;

class ShoppingCart
{
    static void Main()
    {
        // 1️ Dictionary to store product prices
        Dictionary<string, double> cart = new Dictionary<string, double>();

        // 2️ List to maintain insertion order (LinkedDictionary behavior)
        List<string> insertionOrder = new List<string>();

        AddItem(cart, insertionOrder, "Laptop", 75000);
        AddItem(cart, insertionOrder, "Mouse", 500);
        AddItem(cart, insertionOrder, "Keyboard", 1500);
        AddItem(cart, insertionOrder, "Monitor", 12000);

        // 3️ SortedDictionary to sort items by price
        SortedDictionary<double, List<string>> sortedByPrice =
            new SortedDictionary<double, List<string>>();

        foreach (var item in cart)
        {
            if (!sortedByPrice.ContainsKey(item.Value))
                sortedByPrice[item.Value] = new List<string>();

            sortedByPrice[item.Value].Add(item.Key);
        }

        Console.WriteLine("Items in Insertion Order (LinkedDictionary):");
        foreach (string item in insertionOrder)
        {
            Console.WriteLine(item + " : Rs " + cart[item]);
        }

        Console.WriteLine("\nItems Sorted by Price:");
        foreach (var entry in sortedByPrice)
        {
            foreach (var product in entry.Value)
            {
                Console.WriteLine(product + " : Rs " + entry.Key);
            }
        }
    }

    static void AddItem(Dictionary<string, double> cart,
                        List<string> order,
                        string product,
                        double price)
    {
        if (!cart.ContainsKey(product))
        {
            cart[product] = price;
            order.Add(product);
        }
    }
}
