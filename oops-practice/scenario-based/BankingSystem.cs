using System;

class User
{
    // Public fields representing user/account details
    public string UserName;
    public int AccountNumber;
    public int Pin;
    public int Balance;

    // Constructor initializes a new user with starting balance 0
    public User(string userName, int accountNumber, int pin)
    {
        UserName = userName;
        AccountNumber = accountNumber;
        Pin = pin;
        Balance = 0;
    }

    // Displays user name and account number
    public void DisplayUserDetails()
    {
        Console.WriteLine("User Name:" + UserName);
        Console.WriteLine("Account Number:" + AccountNumber);
    }

    // Deposits a positive amount into the account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            // Cast to int to match Balance type (note: truncates cents)
            Balance += (int)amount;
            Console.WriteLine("Deposited Amount:" + amount);
            DisplayBalance();
        }
        else
            Console.WriteLine("Amount must be positive");
    }

    // Withdraws an amount if sufficient balance is available
    public void WithDraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            // Cast to int to match Balance type
            Balance -= (int)amount;
            Console.WriteLine("Withdrawn:" + amount);
        }
        else
            Console.WriteLine("Invalid or Insufficient Balance");
    }

    // Prints the current account balance
    public void DisplayBalance()
    {
        Console.WriteLine("Current Balance:" + Balance);
    }
}

class AccountManager
{
    // Fixed-size array to store up to 10 users
    User[] users = new User[10];
    int count = 0; // Tracks number of created accounts

    // Finds a user by account number and PIN; returns null if not found
    User FindUser(int accNo, int pin)
    {
        for (int i = 0; i < count; i++)
            if (users[i].AccountNumber == accNo && users[i].Pin == pin)
                return users[i];
        return null;
    }

    // Creates a new account after collecting user inputs
    public void CreateAccount()
    {
        if (count >= 10)
        {
            Console.WriteLine("Account Limit Reached");
            return;
        }

        // Basic input sequence (no validation/error handling here)
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Account No: ");
        int acc = int.Parse(Console.ReadLine());
        Console.Write("Enter PIN: ");
        int pin = int.Parse(Console.ReadLine());

        users[count++] = new User(name, acc, pin);
        Console.WriteLine("Account Created Successfully");
    }

    // Modifies either the user's name or PIN after authentication
    public void ModifyAccount()
    {
        Console.Write("Enter Account No: ");
        int acc = int.Parse(Console.ReadLine());
        Console.Write("Enter PIN: ");
        int pin = int.Parse(Console.ReadLine());

        User u = FindUser(acc, pin);
        if (u == null) { Console.WriteLine("Account not found"); return; }

        Console.WriteLine("1.Change Name\n2.Change PIN");
        int ch = int.Parse(Console.ReadLine());

        if (ch == 1) { Console.Write("New Name: "); u.UserName = Console.ReadLine(); }
        else if (ch == 2) { Console.Write("New PIN: "); u.Pin = int.Parse(Console.ReadLine()); }
    }

    // Deletes an account by account number (no PIN check)
    public void DeleteAccount()
    {
        Console.Write("Enter Account No: ");
        int acc = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (users[i].AccountNumber == acc)
            {
                // Shift remaining users left to fill the gap
                for (int j = i; j < count - 1; j++)
                    users[j] = users[j + 1];
                count--;
                Console.WriteLine("Account Deleted");
                return;
            }
        }
        Console.WriteLine("Account not found");
    }

    // Authenticates user and provides a simple menu for transactions
    public void UserMenu()
    {
        Console.Write("Enter Account No: ");
        int acc = int.Parse(Console.ReadLine());
        Console.Write("Enter PIN: ");
        int pin = int.Parse(Console.ReadLine());

        User u = FindUser(acc, pin);
        if (u == null) { Console.WriteLine("Invalid Login"); return; }

        int ch;
        do
        {
            Console.WriteLine("\n1.Deposit\n2.Withdraw\n3.View\n4.Back");
            ch = int.Parse(Console.ReadLine());
            if (ch == 1) { Console.Write("Amount: "); u.Deposit(int.Parse(Console.ReadLine())); }
            else if (ch == 2) { Console.Write("Amount: "); u.WithDraw(int.Parse(Console.ReadLine())); }
            else if (ch == 3) { u.DisplayUserDetails(); u.DisplayBalance(); }
        } while (ch != 4);
    }
}

class Bank
{
    // Static bank name shared across all Bank instances
    static string BankName = "SBI";
    // Branch-specific details
    public string BranchName;
    public string IfscCode;
    public int MinimumBalance;
    public int MaximumTransaction;

    // Initializes bank branch details
    public Bank(string b, string i, int m, int t)
    {
        BranchName = b; IfscCode = i; MinimumBalance = m; MaximumTransaction = t;
    }

    // Displays bank and branch information
    public void DisplayBankDetails()
    {
        Console.WriteLine("\nBank:" + BankName);
        Console.WriteLine("Branch:" + BranchName);
        Console.WriteLine("IFSC:" + IfscCode);
        Console.WriteLine("Min Balance:" + MinimumBalance);
        Console.WriteLine("Max Txn:" + MaximumTransaction);
    }
}

class BankingSystem
{
    // Entry point providing top-level menu for manager, user, and bank details
    static void Main()
    {
        AccountManager manager = new AccountManager();
        Bank bank = new Bank("Delhi", "SBI000123", 2000, 100000);

        int ch;
        do
        {
            Console.WriteLine("\n1.Manager\n2.User\n3.Bank Details\n4.Exit");
            ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                // Manager operations: create, modify, delete accounts
                Console.WriteLine("1.Create\n2.Modify\n3.Delete");
                int managerOption = int.Parse(Console.ReadLine());
                if (managerOption == 1) manager.CreateAccount();
                else if (managerOption == 2) manager.ModifyAccount();
                else if (managerOption == 3) manager.DeleteAccount();
            }
            else if (ch == 2) manager.UserMenu(); // Authenticated user operations
            else if (ch == 3) bank.DisplayBankDetails(); // View bank info

        } while (ch != 4); // Exit when user selects 4
    }
}