using System;
using System.IO;
using System.Linq;

class SortSalary
{
    static void Main()
    {
        string filePath = "employees.csv";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            var sortedEmployees = lines
                .Skip(1) // skip header
                .Select(line => line.Split(','))
                .OrderByDescending(data => int.Parse(data[3]))
                .Take(5);

            Console.WriteLine("Top 5 Highest Paid Employees:\n");

            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine("Name: " + emp[1] + " , Dept: " + emp[2] + " , Salary: " + emp[3]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error while reading or sorting CSV file.");
        }
    }
}
