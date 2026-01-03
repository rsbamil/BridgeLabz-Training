using System;
class Employee
{
    string name;
    int id;
    string designation;
    static string companyName = "ABC Solutions";
    static int totalEmployees = 0;
    public Employee(string name, int id, string designation)
    {
        this.name = name;
        this.id = id;
        this.designation = designation;
        totalEmployees++;
    }
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Employee ID: " + id + ", Name: " + name + ", Designation: " + designation + ", Company: " + companyName);
    }
}
class EmployeeManagementSystem
{
    static void Main()
    {
        Employee e1 = new Employee("Alice", 101, "Developer");
        Employee e2 = new Employee("Bob", 102, "Manager");
        if (e1 is Employee)
        {
            Console.WriteLine("e1 is an instance of Employee");
            e1.DisplayEmployeeInfo();
        }
        if (e2 is Employee)
        {
            Console.WriteLine("e2 is an instance of Employee");
            e2.DisplayEmployeeInfo();
        }
        Employee.DisplayTotalEmployees();
    }
}