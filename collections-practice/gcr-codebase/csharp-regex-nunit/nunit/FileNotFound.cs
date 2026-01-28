using System;
using System.IO;

class FileNotFound
{
    static void Main()
    {
        try
        {
            string content = File.ReadAllText("data.txt");
            Console.WriteLine("File Content:\n");
            Console.WriteLine(content);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
