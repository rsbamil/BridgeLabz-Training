using System;
using System.IO;
using Newtonsoft.Json;

class CsvToJson
{
    static void Main()
    {
        var lines = File.ReadAllLines("data.csv");
        var headers = lines[0].Split(',');

        var list = new System.Collections.Generic.List<object>();

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var obj = new System.Collections.Generic.Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
                obj[headers[j]] = values[j];

            list.Add(obj);
        }

        Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
    }
}
