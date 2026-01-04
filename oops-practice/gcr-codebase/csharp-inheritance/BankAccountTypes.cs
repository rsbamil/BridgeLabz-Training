using System;

class BankAccount
{
    public int AccountNumber;
    public double Balance;

    public BankAccount(int accNo, double balance)
    {
        AccountNumber = accNo;
        Balance = balance;
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public SavingsAccount(int accNo, double balance, double interestRate)
        : base(accNo, balance)
    {
        InterestRate = interestRate;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type : Savings Account");
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit;

    public CheckingAccount(int accNo, double balance, double withdrawalLimit)
        : base(accNo, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type    : Checking Account");
        Console.WriteLine("Withdrawal Limit: ₹" + WithdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount
{
    public int LockInPeriod; // in months

    public FixedDepositAccount(int accNo, double balance, int lockInPeriod)
        : base(accNo, balance)
    {
        LockInPeriod = lockInPeriod;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type  : Fixed Deposit Account");
        Console.WriteLine("Lock-in Period: " + LockInPeriod + " months");
    }
}

class BankAccountTypes
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, 50000, 4.5);
        CheckingAccount ca = new CheckingAccount(102, 30000, 10000);
        FixedDepositAccount fa = new FixedDepositAccount(103, 200000, 24);

        sa.DisplayAccountType();
        Console.WriteLine();

        ca.DisplayAccountType();
        Console.WriteLine();

        fa.DisplayAccountType();
    }
}
