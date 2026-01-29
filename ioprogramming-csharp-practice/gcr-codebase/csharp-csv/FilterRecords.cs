using System;
using System.IO;
class FilterRecords
{
    static void Main()
    {
        string filePath = "students.csv";
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine();
                Console.WriteLine("Students scoring above 80 marks :");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');
                    int marks = int.Parse(fields[2]);
                    if (marks > 80)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file 'students.csv' was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}