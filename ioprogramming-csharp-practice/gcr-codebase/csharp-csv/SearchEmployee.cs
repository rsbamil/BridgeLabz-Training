using System;
using System.IO;

class SearchEmployee
{
    static void Main()
    {
        string filePath = "employees.csv";

        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Department: " + data[2]);
                    Console.WriteLine("Salary: " + data[3]);
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Employee not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading CSV file." + e.Message);
        }
    }
}
