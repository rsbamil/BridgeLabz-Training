using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
class Employee
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}
class Serialization
{
    static void Main()
    {
        string filePath = "employees.dat";

        try
        {
            // Create employee list
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Rohit", Department = "IT", Salary = 50000 },
                new Employee { Id = 2, Name = "Amit", Department = "HR", Salary = 40000 }
            };

            // 🔹 Serialize
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, employees);
            }

            Console.WriteLine("Employees saved successfully.\n");

            // 🔹 Deserialize
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                List<Employee> savedEmployees =
                    (List<Employee>)formatter.Deserialize(fs);

                Console.WriteLine("Employee Details:");
                foreach (Employee emp in savedEmployees)
                {
                    Console.WriteLine(
                        "ID: " + emp.Id + " , Name: " + emp.Name + " , Dept: " + emp.Department + " , Salary: " + emp.Salary
                    );
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
