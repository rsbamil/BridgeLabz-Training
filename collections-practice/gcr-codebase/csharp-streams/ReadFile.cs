using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        string filePath = "Source.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
