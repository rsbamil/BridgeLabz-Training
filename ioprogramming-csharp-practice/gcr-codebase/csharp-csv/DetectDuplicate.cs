using System;
using System.IO;
using System.Collections.Generic;

class DetectDuplicate
{
    static void Main()
    {
        string filePath = "students.csv";

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            HashSet<string> seenIds = new HashSet<string>();

            Console.WriteLine("Duplicate Records:\n");

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');
                string id = data[0];

                if (!seenIds.Add(id))
                {
                    // If Add() returns false → duplicate found
                    Console.WriteLine(lines[i]);
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error while reading CSV file.");
        }
    }
}
