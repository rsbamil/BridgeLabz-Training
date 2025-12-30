using System;
public class Employee
{
    string name="Raj Kapoor";
    int id=1;
    int salary=50000;
    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);

    }
}
class DisplayEmployee
{
    static void Main()
    {
        Employee emp=new Employee();
        emp.DisplayDetails();
    }
}