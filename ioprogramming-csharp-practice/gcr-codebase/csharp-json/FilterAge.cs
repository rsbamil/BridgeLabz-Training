using Newtonsoft.Json.Linq;
using System;

class FilterAge
{
    static void Main()
    {
        string json = @"[
          { 'name':'A', 'age':30 },
          { 'name':'B', 'age':20 }
        ]";

        JArray arr = JArray.Parse(json);
        foreach (var x in arr)
            if ((int)x["age"] > 25)
                Console.WriteLine(x);
    }
}
