using System;
using System.Collections;
using System.Collections.Generic;

class HospitalTriageSystem
{
    static void Main()
    {
        // PriorityQueue<PatientName, Priority>
        // Lower priority value is dequeued first
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        // Enqueue patients (use negative severity for higher priority)
        pq.Enqueue("John", -3);
        pq.Enqueue("Alice", -5);
        pq.Enqueue("Bob", -2);

        Console.WriteLine("Treatment Order:");

        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());
        }
    }
}
