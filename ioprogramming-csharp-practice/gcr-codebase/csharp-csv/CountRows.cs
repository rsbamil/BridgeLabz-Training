using System;
using System.IO;
class CountRows
{
    static void Main()
    {
        string filePath = "employees.csv";
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Exclude header row
            int recordCount = lines.Length > 0 ? lines.Length - 1 : 0;

            Console.WriteLine("Total records (excluding header): " + recordCount);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file 'employees.csv' was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}