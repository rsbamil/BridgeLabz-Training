using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class ReadingLargeFile
{
    static void Main()
    {
        string filePath = "largefile.txt";

        Console.WriteLine("Reading file using StreamReader...");
        MeasureTime("StreamReader", () => ReadUsingStreamReader(filePath));

        Console.WriteLine("\nReading file using FileStream...");
        MeasureTime("FileStream", () => ReadUsingFileStream(filePath));
    }

    // 🔹 StreamReader (Character-based)
    static void ReadUsingStreamReader(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            while (reader.ReadLine() != null)
            {
                // Simulate processing
            }
        }
    }

    // 🔹 FileStream (Byte-based)
    static void ReadUsingFileStream(string path)
    {
        byte[] buffer = new byte[8192];
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                // Simulate processing bytes
            }
        }
    }

    // 🔹 Time Measurement
    static void MeasureTime(string name, Action action)
    {
        Stopwatch sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine(name + " Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
