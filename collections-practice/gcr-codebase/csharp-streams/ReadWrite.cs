using System;
using System.IO;

class ReadWrite
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destinationPath = "destination.txt";

        // Check if source file exists
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        FileStream sourceStream = null;
        FileStream destinationStream = null;

        try
        {
            // Open source file for reading
            sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);

            // Create destination file if it does not exist
            destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

            int data;
            while ((data = sourceStream.ReadByte()) != -1)
            {
                destinationStream.WriteByte((byte)data);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An IO error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            if (sourceStream != null)
                sourceStream.Close();

            if (destinationStream != null)
                destinationStream.Close();
        }
    }
}
