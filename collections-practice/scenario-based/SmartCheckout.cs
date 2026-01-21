using System;
using System.Collections.Generic;

/* ========= CUSTOMER CLASS ========= */

class Customer
{
    public string Name;
    public List<string> Items;

    public Customer(string name, List<string> items)
    {
        Name = name;
        Items = items;
    }
}

/* ========= MAIN ========= */

class SmartCheckout
{
    static void Main()
    {
        // HashMap (Dictionary) for price and stock
        Dictionary<string, double> priceMap = new Dictionary<string, double>
        {
            { "Milk", 50 },
            { "Bread", 30 },
            { "Eggs", 6 }
        };

        Dictionary<string, int> stockMap = new Dictionary<string, int>
        {
            { "Milk", 10 },
            { "Bread", 5 },
            { "Eggs", 20 }
        };

        // Queue for checkout
        Queue<Customer> checkoutQueue = new Queue<Customer>();

        // Add customers
        checkoutQueue.Enqueue(new Customer("Alice",
            new List<string> { "Milk", "Bread" }));

        checkoutQueue.Enqueue(new Customer("Bob",
            new List<string> { "Eggs", "Milk" }));

        // Process customers
        while (checkoutQueue.Count > 0)
        {
            Customer current = checkoutQueue.Dequeue();
            double totalBill = 0;

            Console.WriteLine("\nBilling for " + current.Name);

            foreach (string item in current.Items)
            {
                if (stockMap[item] > 0)
                {
                    totalBill += priceMap[item];
                    stockMap[item]--;   // update stock
                    Console.WriteLine(item + " : Rs " + priceMap[item]);
                }
                else
                {
                    Console.WriteLine(item + " : Out of Stock");
                }
            }

            Console.WriteLine("Total Bill: Rs " + totalBill);
        }

        Console.WriteLine("\nRemaining Stock:");
        foreach (var item in stockMap)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
