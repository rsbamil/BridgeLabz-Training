using System;

class BankAccount
{
    // Public – accessible everywhere
    public int accountNumber;

    // Protected – accessible in this class & child classes
    protected string accountHolder;

    // Private – accessible only inside this class
    private double balance;

    // Constructor
    public BankAccount(int accNo, string holder, double bal)
    {
        accountNumber = accNo;
        accountHolder = holder;
        balance = bal;
    }

    // Public method to GET balance
    public double GetBalance()
    {
        return balance;
    }

    // Public method to SET balance
    public void SetBalance(double amount)
    {
        if (amount >= 0)
            balance = amount;
        else
            Console.WriteLine("Invalid amount!");
    }
}
class SavingsAccount : BankAccount
{
    public SavingsAccount(int accNo, string holder, double bal)
        : base(accNo, holder, bal)
    {
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber); // public ✔
        Console.WriteLine("Account Holder: " + accountHolder); // protected ✔
    }
}
class BankAccountManager
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, "Rohit Kumar", 5000);

        sa.DisplayDetails();

        Console.WriteLine("Current Balance: " + sa.GetBalance());

        sa.SetBalance(8000);
        Console.WriteLine("Updated Balance: " + sa.GetBalance());
    }
}
