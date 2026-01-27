using System;
using System.IO;

class Input
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter your name: ");
            string name = reader.ReadLine();

            Console.Write("Enter your age: ");
            string age = reader.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();

            using (StreamWriter writer = new StreamWriter("UserData.txt"))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Language: " + language);
            }

            Console.WriteLine("\nData saved successfully to UserData.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
