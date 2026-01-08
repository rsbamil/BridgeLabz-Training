using System;

// Process node
class ProcessNode
{
    public int Id;
    public ProcessNode Next;

    public ProcessNode(int id)
    {
        Id = id;
    }
}

class RoundRobin
{
    private ProcessNode head = null;

    public void AddProcess(int id)
    {
        ProcessNode node = new ProcessNode(id);

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    public void Display()
    {
        ProcessNode temp = head;
        do
        {
            Console.WriteLine("Process " + temp.Id);
            temp = temp.Next;
        } while (temp != head);
    }
}

class RoundRobinAlgorithm
{
    static void Main()
    {
        RoundRobin rr = new RoundRobin();

        rr.AddProcess(1);
        rr.AddProcess(2);
        rr.AddProcess(3);

        rr.Display();
    }
}