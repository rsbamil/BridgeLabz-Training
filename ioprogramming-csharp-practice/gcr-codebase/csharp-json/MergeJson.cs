using Newtonsoft.Json.Linq;
using System;

class MergeJson
{
    static void Main()
    {
        JObject j1 = JObject.Parse(@"{ 'name':'Amit' }");
        JObject j2 = JObject.Parse(@"{ 'age':25 }");

        j1.Merge(j2);
        Console.WriteLine(j1);
    }
}
