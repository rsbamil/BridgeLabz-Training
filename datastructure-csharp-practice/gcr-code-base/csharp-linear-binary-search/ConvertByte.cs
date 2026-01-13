using System;
using System.IO;
using System.Text;

class ConvertByte
{
    static void Main()
    {
        string filePath = "sample.bin";
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                int ch;
                if ((ch = reader.Read()) != -1)
                {
                    Console.WriteLine((char)ch);
                }

            }
        }
    }
}