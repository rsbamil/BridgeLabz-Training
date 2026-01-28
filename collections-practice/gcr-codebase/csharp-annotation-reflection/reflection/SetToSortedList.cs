using System;
using System.Collections.Generic;
class SetToSortedList
{
    static void Main()
    {
        SetToSortedList obj = new SetToSortedList();
        HashSet<int> set = new HashSet<int>() { 5, 3, 8, 1, 2 };
        List<int> sortedList = obj.ConvertSetToSortedList(set);
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }
    List<int> ConvertSetToSortedList(HashSet<int> set)
    {
        List<int> list = new List<int>(set);
        list.Sort();
        return list;
    }
}