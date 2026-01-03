using System;
class BankAccount
{
    readonly int accountNumber;
    string accountHolderName;
    static string bankName = "ABC Bank";
    static int totalAccounts = 0;
    public BankAccount(int accountNumber, string accountHolderName)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        totalAccounts++;
    }
    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }
    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber + ", Account Holder: " + accountHolderName + ", Bank: " + bankName);
    }
}
class BankAccountSystem
{
    static void Main()
    {
        BankAccount ba1 = new BankAccount(1001, "Rk");
        BankAccount ba2 = new BankAccount(1001, "Dev");
        if (ba1 is BankAccount)
        {
            Console.WriteLine("ba1 is an instance of BankAccount");
            ba1.DisplayAccountInfo();
        }
        if (ba2 is BankAccount)
        {
            Console.WriteLine("ba2 is an instance of BankAccount");
            ba2.DisplayAccountInfo();
        }
        Console.WriteLine("Total Bank Accounts: " + BankAccount.GetTotalAccounts());
    }
}