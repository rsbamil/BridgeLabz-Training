using System;
using System.Collections.Generic;
class Frequency
{
    static void Main()
    {
        Frequency obj = new Frequency();
        List<string> items = new List<string>() { "apple", "banana", "apple", "orange", "banana", "apple" };
        obj.FindFrequency(items);
    }
    void FindFrequency(List<string> items)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        foreach (string item in items)
        {
            if (freq.ContainsKey(item))
            {
                freq[item]++;
            }
            else
            {
                freq[item] = 1;
            }
        }
        foreach (var pair in freq)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}