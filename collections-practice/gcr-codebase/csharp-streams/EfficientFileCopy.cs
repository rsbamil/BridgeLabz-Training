using System;
using System.Diagnostics;
using System.IO;

class EfficientFileCopy
{
    static void Main()
    {
        string sourcePath = "largefile.dat";
        string destUnbuffered = "copy_unbuffered.dat";
        string destBuffered = "copy_buffered.dat";

        Console.WriteLine("Starting File Copy Comparison...\n");

        long unbufferedTime = CopyUsingFileStream(sourcePath, destUnbuffered);
        long bufferedTime = CopyUsingBufferedStream(sourcePath, destBuffered);

        Console.WriteLine("\n----- PERFORMANCE RESULT -----");
        Console.WriteLine("Unbuffered FileStream Time : " + unbufferedTime + " ms");
        Console.WriteLine("BufferedStream Time       : " + bufferedTime + " ms");

        Console.WriteLine(
            bufferedTime < unbufferedTime
            ? "BufferedStream is faster"
            : "Unbuffered performed better (rare case)"
        );
    }

    static long CopyUsingFileStream(string source, string destination)
    {
        byte[] buffer = new byte[4096];
        Stopwatch stopwatch = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static long CopyUsingBufferedStream(string source, string destination)
    {
        byte[] buffer = new byte[4096];
        Stopwatch stopwatch = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite))
        {
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}
