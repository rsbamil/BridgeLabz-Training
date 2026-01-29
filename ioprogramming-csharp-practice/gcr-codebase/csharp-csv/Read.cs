using System;
using System.IO;
class Read
{
    static void Main()
    {
        string filePath = "employees.csv";
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    Console.WriteLine(columns[0] + " | " + columns[1] + " | " + columns[4]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred : " + ex.Message);
        }
    }
}