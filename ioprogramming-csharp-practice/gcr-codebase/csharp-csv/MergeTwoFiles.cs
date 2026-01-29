using System;
using System.IO;
using System.Collections.Generic;

class MergeTwoFiles
{
    static void Main()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";

        Dictionary<string, string> studentMap = new Dictionary<string, string>();

        try
        {
            // Read first CSV (ID, Name, Age)
            string[] lines1 = File.ReadAllLines(file1);
            for (int i = 1; i < lines1.Length; i++) // skip header
            {
                string[] data = lines1[i].Split(',');
                studentMap[data[0]] = data[1] + "," + data[2];
            }

            // Read second CSV and write merged output
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");

                string[] lines2 = File.ReadAllLines(file2);
                for (int i = 1; i < lines2.Length; i++) // skip header
                {
                    string[] data = lines2[i].Split(',');
                    string id = data[0];

                    if (studentMap.ContainsKey(id))
                    {
                        writer.WriteLine(id + "," + studentMap[id] + "," + data[1] + "," + data[2]);
                    }
                }
            }

            Console.WriteLine("CSV files merged successfully.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error while merging CSV files.");
        }
    }
}
