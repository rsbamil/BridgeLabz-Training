using System;
using System.IO;

class UsingStatement
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("Source.txt"))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
