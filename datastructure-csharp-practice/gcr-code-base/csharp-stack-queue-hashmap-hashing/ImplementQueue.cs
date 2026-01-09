using System;
using System.Collections.Generic;

class ImplementQueue
{
    // Stack for enqueue operation
    static Stack<int> stack1 = new Stack<int>();

    // Stack for dequeue operation
    static Stack<int> stack2 = new Stack<int>();

    // Enqueue element into queue
    static void Enqueue(int value)
    {
        // Push element into first stack
        stack1.Push(value);
    }

    // Dequeue element from queue
    static int Dequeue()
    {
        // If both stacks are empty, queue is empty
        if (stack1.Count == 0 && stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        // Transfer elements from stack1 to stack2 if stack2 is empty
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        // Pop from second stack (FIFO behavior)
        return stack2.Pop();
    }
    static void DisplayQueue()
    {
        if (stack1.Count == 0 && stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.Write("Queue elements: ");

        // Display elements in stack2 (front of queue)
        foreach (int item in stack2)
        {
            Console.Write(item + " ");
        }

        // Display elements in stack1 in reverse order
        int[] temp = stack1.ToArray();
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            Console.Write(temp[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Enqueue(10);
        Enqueue(20);
        Enqueue(30);

        DisplayQueue();     // 10 20 30
        Console.WriteLine("Dequeue operation results:");
        Console.WriteLine(Dequeue()); // 10
        DisplayQueue();     // 20 30
        Console.WriteLine("Dequeue operation results:");
        Console.WriteLine(Dequeue()); // 20
        DisplayQueue();     // 30
    }

}