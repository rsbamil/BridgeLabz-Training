using System;

// Simple Loan Interface
interface ILoanable
{
    bool CalculateLoanEligibility();
}

// Abstract Base Class
abstract class BankAccount
{
    public int accountNumber;
    protected string holderName;
    private double balance;

    public BankAccount(int accNo, string name, double bal)
    {
        accountNumber = accNo;
        holderName = name;
        balance = bal;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid Withdraw");
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nAccount Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }

    public abstract double CalculateInterest();
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(int accNo, string name, double bal)
        : base(accNo, name, bal) { }

    public override double CalculateInterest()
    {
        return GetBalance() * 0.04;   // 4%
    }

    public bool CalculateLoanEligibility()
    {
        return GetBalance() > 5000;
    }
}

// Current Account
class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(int accNo, string name, double bal)
        : base(accNo, name, bal) { }

    public override double CalculateInterest()
    {
        return GetBalance() * 0.02;   // 2%
    }

    public bool CalculateLoanEligibility()
    {
        return GetBalance() > 10000;
    }
}

// Main System
class BankingSystem
{
    static void ProcessAccount(BankAccount acc)
    {
        acc.DisplayDetails();
        Console.WriteLine("Interest: " + acc.CalculateInterest());
    }

    static void Main()
    {
        BankAccount[] accounts = new BankAccount[2];

        accounts[0] = new SavingsAccount(101, "Rohit", 8000);
        accounts[1] = new CurrentAccount(202, "Amit", 15000);

        foreach (BankAccount acc in accounts)
        {
            ProcessAccount(acc);

            ILoanable loanAcc = acc as ILoanable;

            if (loanAcc.CalculateLoanEligibility())
                Console.WriteLine("Eligible for Loan");
            else
                Console.WriteLine("Not Eligible for Loan");
        }

        Console.WriteLine("\nTransactions on Savings Account:");

        accounts[0].Deposit(2000);
        accounts[0].Withdraw(1000);

        accounts[0].DisplayDetails();
    }
}
