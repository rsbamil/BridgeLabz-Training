using System;
using System.Collections.Generic;
class RotateElems
{
    static void Main()
    {
        RotateElems obj = new RotateElems();
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        int k = 2;
        obj.RotateList(list, k);
        Console.WriteLine("Rotated List : " + string.Join(", ", list));
    }
    void RotateList(List<int> list, int k)
    {
        List<int> temp = new List<int>();
        int n = list.Count;
        k = k % n;
        for (int i = k; i < n; i++)
        {
            temp.Add(list[i]);
        }
        for (int i = 0; i < k; i++)
        {
            temp.Add(list[i]);
        }
        for (int i = 0; i < n; i++)
        {
            list[i] = temp[i];
        }
    }
}