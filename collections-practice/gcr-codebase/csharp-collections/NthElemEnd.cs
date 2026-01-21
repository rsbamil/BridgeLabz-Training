using System;
using System.Collections.Generic;
class NthElemEnd
{
    static void Main()
    {
        NthElemEnd obj = new NthElemEnd();
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddLast(40);
        list.AddLast(50);
        int n = 2;
        int result = obj.FindNthFromEnd(list, n);
        Console.WriteLine(n + "th element from the end is: " + result);
    }
    int FindNthFromEnd(LinkedList<int> list, int n)
    {
        LinkedListNode<int> first = list.First;
        LinkedListNode<int> next = list.First;
        for (int i = 0; i < n; i++)
        {
            if (first == null)
            {
                return -1;
            }
            first = first.Next;
        }
        while (first != null)
        {
            first = first.Next;
            next = next.Next;
        }
        return next.Value;
    }
}