using Newtonsoft.Json;
using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class ListToJsonArray
{
    static void Main()
    {
        var list = new List<Person>
        {
            new Person{ Name="A", Age=30 },
            new Person{ Name="B", Age=20 }
        };

        Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
    }
}
