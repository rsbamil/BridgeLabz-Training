using System;
using System.IO;
class Write
{
    static void Main()
    {
        string filePath = "output.csv";
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Position,Salary");
                writer.WriteLine("1,John Doe,Engineering,Software Engineer,75000");
                writer.WriteLine("2,Jane Smith,Marketing,Marketing Manager,68000");
                writer.WriteLine("3,Bob Johnson,Sales,Sales Executive,72000");
            }
            Console.WriteLine("Data written to " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred : " + ex.Message);
        }
    }
}