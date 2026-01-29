using System;
using System.IO;

class UpdateSalary
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        try
        {
            string[] lines = File.ReadAllLines(inputFile);

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                if (data[2] == "IT")
                {
                    double salary = double.Parse(data[3]);
                    salary = salary + (salary * 0.10);
                    data[3] = salary.ToString();
                }

                lines[i] = string.Join(",", data);
            }

            File.WriteAllLines(outputFile, lines);
            Console.WriteLine("Salary updated and saved to new CSV file.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error while updating CSV file.");
        }
    }
}
