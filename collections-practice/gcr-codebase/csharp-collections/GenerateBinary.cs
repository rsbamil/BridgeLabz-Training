using System;
using System.Collections.Generic;

class GenerateBinary
{
    static void Main()
    {
        int N = 10;
        GenerateBinaryNumbers(N);
    }

    static void GenerateBinaryNumbers(int n)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            Console.Write(current + " ");

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}
