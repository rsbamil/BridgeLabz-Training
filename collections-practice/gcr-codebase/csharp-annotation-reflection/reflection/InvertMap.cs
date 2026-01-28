using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Dictionary<int, List<string>> inverted =
            new Dictionary<int, List<string>>();

        foreach (var pair in input)
        {
            int value = pair.Value;
            string key = pair.Key;

            if (!inverted.ContainsKey(value))
            {
                inverted[value] = new List<string>();
            }

            inverted[value].Add(key);
        }

        Console.WriteLine("Output:");
        foreach (var pair in inverted)
        {
            Console.Write(pair.Key + " = [");
            Console.WriteLine(string.Join(", ", pair.Value) + "]");
        }
    }
}
