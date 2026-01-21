using System;
using System.Collections.Generic;
class SymmetricDiff
{
    static void Main()
    {
        SymmetricDiff obj = new SymmetricDiff();
        HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int>() { 4, 5, 6, 7, 8 };
        HashSet<int> symDiff = obj.SymmetricDifference(setA, setB);
        Console.WriteLine("Symmetric Difference: " + string.Join(", ", symDiff));

    }
    HashSet<int> SymmetricDifference(HashSet<int> setA, HashSet<int> setB)
    {
        HashSet<int> result = new HashSet<int>(setA);
        foreach (int item in setB)
        {
            if (result.Contains(item))
            {
                result.Remove(item);
            }
            else
            {
                result.Add(item);
            }
        }
        return result;
    }
}