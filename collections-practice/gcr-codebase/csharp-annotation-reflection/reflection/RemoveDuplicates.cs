using System;
using System.Collections.Generic;
class RemoveDuplicates
{
    static void Main()
    {
        RemoveDuplicates obj = new RemoveDuplicates();
        List<int> list = new List<int>() { 1, 2, 2, 3, 4, 4, 5, 5, 5 };
        List<int> result = obj.RemoveDups(list);
        Console.WriteLine("List after removing duplicates: " + string.Join(", ", result));
    }
    List<int> RemoveDups(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> res = new List<int>();
        foreach (int num in list)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                res.Add(num);
            }
        }
        return res;
    }
}