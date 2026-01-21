using System;
using System.Collections.Generic;
class UnionIntersection
{
    static void Main()
    {
        UnionIntersection obj = new UnionIntersection();
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
        HashSet<int> unionSet = obj.Union(set1, set2);
        HashSet<int> intersectionSet = obj.Intersection(set1, set2);
        Console.WriteLine("Union of the two sets: " + string.Join(", ", unionSet));
        Console.WriteLine("Intersection of the two sets: " + string.Join(", ", intersectionSet));
    }
    HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> unionSet = new HashSet<int>(set1);
        foreach (int item in set2)
        {
            unionSet.Add(item);
        }
        return unionSet;
    }
    HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersectionSet = new HashSet<int>();
        foreach (int item in set1)
        {
            if (set2.Contains(item))
            {
                intersectionSet.Add(item);
            }
        }
        return intersectionSet;
    }
}