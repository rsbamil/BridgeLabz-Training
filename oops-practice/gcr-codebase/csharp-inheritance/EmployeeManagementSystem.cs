using System;

// Base Class
public class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: ₹" + Salary);
    }
}

// Manager Class
public class Manager : Employee
{
    public int TeamSize;

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("\n--- Manager Details ---");
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

// Developer Class
public class Developer : Employee
{
    public string ProgrammingLanguage;

    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("\n--- Developer Details ---");
        base.DisplayDetails();
        Console.WriteLine("Language: " + ProgrammingLanguage);
    }
}

// Intern Class
public class Intern : Employee
{
    public string InternshipDuration;

    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary)
    {
        InternshipDuration = duration;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("\n--- Intern Details ---");
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}

// Main Class
class EmployeeManagementSystem
{
    static void Main()
    {
        Employee e1 = new Manager("Rohit", 101, 80000, 10);
        Employee e2 = new Developer("Aman", 102, 60000, "C#");
        Employee e3 = new Intern("Neha", 103, 15000, "6 Months");

        e1.DisplayDetails();
        e2.DisplayDetails();
        e3.DisplayDetails();
    }
}
