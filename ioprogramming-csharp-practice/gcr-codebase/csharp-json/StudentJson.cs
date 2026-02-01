using Newtonsoft.Json;
using System;
using System.Collections.Generic;

class Student
{
    public string name { get; set; }
    public int age { get; set; }
    public List<string> subjects { get; set; }
}

class StudentJson
{
    static void Main()
    {
        Student s = new Student
        {
            name = "Rohit",
            age = 22,
            subjects = new List<string> { "Maths", "Physics", "CS" }
        };

        string json = JsonConvert.SerializeObject(s, Formatting.Indented);
        Console.WriteLine(json);
    }
}
