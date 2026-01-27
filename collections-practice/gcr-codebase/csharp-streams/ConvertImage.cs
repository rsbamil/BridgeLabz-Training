using System;
using System.IO;

class ConvertImage
{
    static void Main()
    {
        string sourceImage = "original.jpg";
        string copiedImage = "copy.jpg";

        try
        {
            // Read image into byte array
            byte[] imageBytes = File.ReadAllBytes(sourceImage);

            // Write byte array to new image using MemoryStream
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes(copiedImage, ms.ToArray());
            }

            // Verify both files are identical
            bool isSame = File.ReadAllBytes(sourceImage)
                .Length == File.ReadAllBytes(copiedImage).Length;

            Console.WriteLine(isSame
                ? "Image copied successfully. Files are identical."
                : "Files are different.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
