using System;

class Employee
{
    // Public – accessible everywhere
    public int employeeID;

    // Protected – accessible in this class and child classes
    protected string department;

    // Private – accessible only inside this class
    private double salary;

    // Constructor
    public Employee(int id, string dept, double sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Public method to GET salary
    public double GetSalary()
    {
        return salary;
    }

    // Public method to MODIFY salary
    public void SetSalary(double amount)
    {
        if (amount >= 0)
            salary = amount;
        else
            Console.WriteLine("Invalid Salary Amount!");
    }
}
class Manager : Employee
{
    public Manager(int id, string dept, double sal)
        : base(id, dept, sal)
    {
    }

    public void DisplayManagerDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID); // public ✔
        Console.WriteLine("Department: " + department); // protected ✔
    }
}
class EmployeeRecords
{
    static void Main()
    {
        Manager m = new Manager(201, "IT", 60000);

        m.DisplayManagerDetails();

        Console.WriteLine("Salary: " + m.GetSalary());

        m.SetSalary(75000);
        Console.WriteLine("Updated Salary: " + m.GetSalary());
    }
}
