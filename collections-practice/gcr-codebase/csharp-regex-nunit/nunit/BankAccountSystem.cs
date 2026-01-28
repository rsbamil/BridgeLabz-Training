using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
        : base("Insufficient balance!")
    {
    }
}
class BankAccount
{
    double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException();

        if (amount > balance)
            throw new InsufficientFundsException();

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }
}
class BankAccountSystem
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(5000);

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount entered!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}
