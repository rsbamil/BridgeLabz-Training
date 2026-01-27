using System;
using System.IO;
using System.Text;

class ConvertUpperCase
{
    static void Main()
    {
        string inputFile = "Source.txt";
        string outputFile = "output.txt";

        try
        {
            using (FileStream fsRead = new FileStream(inputFile, FileMode.Open))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))
            using (FileStream fsWrite = new FileStream(outputFile, FileMode.Create))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File converted to lowercase successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
