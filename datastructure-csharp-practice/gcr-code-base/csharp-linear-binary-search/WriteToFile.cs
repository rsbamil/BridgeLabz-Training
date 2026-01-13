using System;
using System.IO;
using System.Text;
class WriteToFile
{
    static void Main()
    {
        string filePath = "input.txt";
        Console.WriteLine("Enter text (type 'exit' to finish): ");
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                writer.WriteLine(input);
            }
        }
        Console.WriteLine("User input successfully written to file.");
    }
}