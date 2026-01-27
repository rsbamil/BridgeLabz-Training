using System;
using System.IO;

class StoreRetrieve
{
    static void Main()
    {
        string filePath = "student.dat";

        // Write data to binary file
        using (FileStream fsWrite = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fsWrite))
        {
            writer.Write(101);          // Roll Number
            writer.Write("Rohit");      // Name
            writer.Write(8.75);         // GPA
        }

        // Read data from binary file
        using (FileStream fsRead = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fsRead))
        {
            int rollNo = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine("Student Details:");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("GPA: " + gpa);
        }
    }
}
