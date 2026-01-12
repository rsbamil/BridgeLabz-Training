using System;

interface IApprovable
{
    void ApproveLoan();
    int CalculateEMI();
}

class Application
{
    private string Name;
    private double CreditScore;
    private int Income;
    private int LoanAmount;

    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public double creditScore
    {
        get { return CreditScore; }
        set { CreditScore = value; }
    }

    public int income
    {
        get { return Income; }
        set { Income = value; }
    }

    public int loanAmount
    {
        get { return LoanAmount; }
        set { LoanAmount = value; }
    }

    public override string ToString()
    {
        return "Application Details:\n" +
               "Name: " + Name + "\n" +
               "Credit Score: " + CreditScore + "\n" +
               "Income: " + Income + "\n" +
               "Loan Amount: " + LoanAmount;
    }
}

class LoanApplication : IApprovable
{
    protected string LoanType;
    protected int Term;
    protected double InterestRate;
    protected int LoanAmount;

    public LoanApplication(string loanType, int term, double interestRate, int loanAmount)
    {
        LoanType = loanType;
        Term = term;
        InterestRate = interestRate;
        LoanAmount = loanAmount;
    }

    public void ApproveLoan()
    {
        Console.WriteLine("Loan Approved for " + LoanType);
    }

    public virtual int CalculateEMI()
    {
        double R = InterestRate / (12 * 100);
        double emi = LoanAmount * R * Math.Pow(1 + R, Term)
                     / (Math.Pow(1 + R, Term) - 1);

        return (int)emi;
    }
}

class Personal : LoanApplication
{
    public Personal(int term, int loanAmount)
        : base("Personal Loan", term, 12.0, loanAmount) { }

    public override int CalculateEMI()
    {
        // Slightly higher EMI due to higher risk
        return base.CalculateEMI() + 500;
    }
}
class Home : LoanApplication
{
    public Home(int term, int loanAmount) : base("Home Loan", term, 8.5, loanAmount) { }
    public override int CalculateEMI()
    {
        // Lower EMI due to lower interest rate
        return base.CalculateEMI() - 300;
    }
}
class Auto : LoanApplication
{
    public Auto(int term, int loanAmount) : base("Auto Loan", term, 10.0, loanAmount) { }
    public override int CalculateEMI()
    {
        // Standard EMI calculation
        return base.CalculateEMI();
    }
}

class LoanBuddy
{
    static void Main()
    {
        Application app = new Application();
        app.name = "Rohit";
        app.creditScore = 720;
        app.income = 80000;
        app.loanAmount = 300000;

        Console.WriteLine(app);
        Console.WriteLine("\n------------------------------------ ");
        IApprovable loan = new Personal(36, app.loanAmount);
        loan.ApproveLoan();
        Console.WriteLine("EMI: " + loan.CalculateEMI());
        Console.WriteLine("\n------------------------------------ ");
        loan = new Home(120, app.loanAmount);
        loan.ApproveLoan();
        Console.WriteLine("EMI: " + loan.CalculateEMI());
        Console.WriteLine("\n------------------------------------ ");
        loan = new Auto(60, app.loanAmount);
        loan.ApproveLoan();
        Console.WriteLine("EMI: " + loan.CalculateEMI());
    }
}
