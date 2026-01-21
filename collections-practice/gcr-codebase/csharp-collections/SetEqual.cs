using System;
using System.Collections.Generic;
class SetEqual
{
    static void Main()
    {
        SetEqual obj = new SetEqual();
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 5, 4, 3, 2, 1 };
        bool result = obj.AreSetsEqual(set1, set2);
        Console.WriteLine("Are the two sets equal? " + result);
    }
    bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        if (set1.Count != set2.Count)
        {
            return false;
        }
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
            {
                return false;
            }
        }
        return true;
    }
}