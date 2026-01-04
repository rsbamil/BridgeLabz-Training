using System;

public class Employee
{
    public string EmpName;

    public Employee(string name)
    {
        EmpName = name;
    }

    public void Display()
    {
        Console.WriteLine("     Employee: " + EmpName);
    }
}

public class Department
{
    public string DeptName;
    public Employee[] Employees;
    int empCount = 0;

    public Department(string name, int size)
    {
        DeptName = name;
        Employees = new Employee[size];
    }

    public void AddEmployee(string empName)
    {
        if (empCount < Employees.Length)
        {
            Employees[empCount] = new Employee(empName); // Created inside Dept → Strong ownership
            empCount++;
        }
    }

    public void ShowEmployees()
    {
        Console.WriteLine("  Department: " + DeptName);
        for (int i = 0; i < empCount; i++)
        {
            Employees[i].Display();
        }
    }
}

public class Company
{
    public string CompanyName;
    public Department[] Departments;
    int deptCount = 0;

    public Company(string name, int size)
    {
        CompanyName = name;
        Departments = new Department[size];
    }

    public void AddDepartment(string deptName, int empSize)
    {
        if (deptCount < Departments.Length)
        {
            Departments[deptCount] = new Department(deptName, empSize); // Created inside Company
            deptCount++;
        }
    }

    public void ShowCompany()
    {
        Console.WriteLine("\nCompany: " + CompanyName);
        for (int i = 0; i < deptCount; i++)
        {
            Departments[i].ShowEmployees();
        }
    }

    // Composition destroy
    public void DeleteCompany()
    {
        Departments = null;
        Console.WriteLine("\nCompany and all Departments & Employees destroyed!");
    }
}

class CompanyDepartment
{
    static void Main()
    {
        Company comp = new Company("TechSoft", 3);

        comp.AddDepartment("IT", 3);
        comp.AddDepartment("HR", 2);

        comp.Departments[0].AddEmployee("Rohit");
        comp.Departments[0].AddEmployee("Aman");
        comp.Departments[1].AddEmployee("Neha");

        comp.ShowCompany();

        // Destroy Company → All departments & employees are destroyed
        comp.DeleteCompany();
    }
}
