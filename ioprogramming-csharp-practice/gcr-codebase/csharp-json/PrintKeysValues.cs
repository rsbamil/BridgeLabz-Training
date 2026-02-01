using Newtonsoft.Json.Linq;
using System;

class PrintKeysValues
{
    static void Main()
    {
        JObject obj = JObject.Parse(@"{ 'id':1, 'name':'Test' }");

        foreach (var p in obj)
            Console.WriteLine($"{p.Key} : {p.Value}");
    }
}
