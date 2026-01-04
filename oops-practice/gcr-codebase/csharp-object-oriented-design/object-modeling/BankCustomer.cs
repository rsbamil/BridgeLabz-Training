using System;

public class Customer
{
    public string Name;
    public int AccountNumber;
    public double Balance;
    public Bank BankRef;   // Association (Customer is linked to Bank)

    public Customer(string name)
    {
        Name = name;
    }

    // Called after account is opened by Bank
    public void SetAccount(int accNo, double bal, Bank b)
    {
        AccountNumber = accNo;
        Balance = bal;
        BankRef = b;
    }

    public void ViewBalance()
    {
        Console.WriteLine("\nCustomer: " + Name);
        Console.WriteLine("Bank: " + BankRef.BankName);
        Console.WriteLine("Account No: " + AccountNumber);
        Console.WriteLine("Balance: ₹" + Balance);
    }
}

public class Bank
{
    public string BankName;
    public Customer[] Customers;
    int count = 0;

    public Bank(string name, int size)
    {
        BankName = name;
        Customers = new Customer[size];
    }

    // Association created here
    public void OpenAccount(Customer c, double initialBalance)
    {
        if (count < Customers.Length)
        {
            int accNo = 1000 + count;
            Customers[count] = c;
            c.SetAccount(accNo, initialBalance, this);   // Link Customer ↔ Bank
            count++;

            Console.WriteLine("Account created for " + c.Name + " in " + BankName);
        }
        else
        {
            Console.WriteLine("Bank database full!");
        }
    }
}

class BankCustomer
{
    static void Main()
    {
        Bank sbi = new Bank("SBI Bank", 5);

        Customer c1 = new Customer("Rohit");
        Customer c2 = new Customer("Aman");

        sbi.OpenAccount(c1, 5000);
        sbi.OpenAccount(c2, 10000);

        c1.ViewBalance();
        c2.ViewBalance();
    }
}
