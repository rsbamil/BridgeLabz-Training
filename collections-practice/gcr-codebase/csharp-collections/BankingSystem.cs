using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        // 1️ Dictionary to store account balances
        Dictionary<int, double> accounts = new Dictionary<int, double>();

        accounts[101] = 5000;
        accounts[102] = 12000;
        accounts[103] = 8000;

        // 2️ Queue to process withdrawal requests
        Queue<int> withdrawalQueue = new Queue<int>();
        withdrawalQueue.Enqueue(102);
        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        // Withdrawal amount (same for simplicity)
        double withdrawAmount = 3000;

        Console.WriteLine("Processing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            int accNo = withdrawalQueue.Dequeue();

            if (accounts[accNo] >= withdrawAmount)
            {
                accounts[accNo] -= withdrawAmount;
                Console.WriteLine("Account " + accNo + " new balance: " + accounts[accNo]);
            }
            else
            {
                Console.WriteLine("Account " + accNo + " insufficient balance");
            }
        }

        // 3️⃣ SortedDictionary to sort customers by balance
        SortedDictionary<double, List<int>> sortedByBalance =
            new SortedDictionary<double, List<int>>();

        foreach (var acc in accounts)
        {
            if (!sortedByBalance.ContainsKey(acc.Value))
                sortedByBalance[acc.Value] = new List<int>();

            sortedByBalance[acc.Value].Add(acc.Key);
        }

        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var entry in sortedByBalance)
        {
            foreach (var accNo in entry.Value)
            {
                Console.WriteLine("Account " + accNo + " : " + entry.Key);
            }
        }
    }
}
