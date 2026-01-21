using System;
using System.Collections.Generic;
class ReverseQueue
{
    static void Main()
    {
        ReverseQueue obj = new ReverseQueue();
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        Console.WriteLine("Original Queue: " + string.Join(", ", queue));
        obj.Reverse(queue);
        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
    void Reverse(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
    }
}