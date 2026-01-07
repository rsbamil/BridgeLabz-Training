using System;
interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
    void DisplayDetails();
}
abstract class Employee : IDepartment
{
    int employeeId;
    string name;
    int baseSalary;
    string departmentName;
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }
    abstract public int CalculateSalary();
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Base Salary: " + baseSalary);
        Console.WriteLine("Department: " + departmentName);
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
    public void AssignDepartment(string departmentName)
    {
        this.departmentName = departmentName;
    }
    public string GetDepartmentDetails()
    {
        return "Employee " + Name + " works in " + departmentName + " department.";
    }

}
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int employeeId, string name, int baseSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;

    }
    public override int CalculateSalary()
    {
        return BaseSalary + 10000; // Full-time employees get a fixed bonus
    }
}
class PartTimeEmployee : Employee
{
    int workingHours;
    public PartTimeEmployee(int employeeId, string name, int baseSalary, int workingHours)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
        this.workingHours = workingHours;
    }
    public override int CalculateSalary()
    {
        return BaseSalary + (workingHours * 500); // Part-time employees get paid per hour
    }
}
class EmployeeManagementSystem
{
    static void Main()
    {
        IDepartment[] employees = new Employee[2];
        employees[0] = new FullTimeEmployee(1, "RK", 50000);
        employees[1] = new PartTimeEmployee(2, "AJ", 20000, 20);
        employees[0].AssignDepartment("IT");
        employees[1].AssignDepartment("HR");
        foreach (var emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine(emp.GetDepartmentDetails());
            Console.WriteLine();
        }
    }
}