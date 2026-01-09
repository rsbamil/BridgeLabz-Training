using System;
using System.Collections.Generic;

class SortStackUsingRec
{
    // Sorts the entire stack
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0)
            return;

        int top = stack.Pop();
        SortStack(stack);
        InsertInSortedOrder(stack, top);
    }

    // Inserts element in sorted order (smallest at top)
    static void InsertInSortedOrder(Stack<int> stack, int value)
    {
        // Change condition here 👇
        if (stack.Count == 0 || stack.Peek() >= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertInSortedOrder(stack, value);
        stack.Push(temp);
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(3);
        stack.Push(1);
        stack.Push(2);

        Console.WriteLine("Stack before sorting :");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("\nStack after sorting :");
        PrintStack(stack);
    }

    static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
            Console.WriteLine(item + " ");
        Console.WriteLine();
    }
}
