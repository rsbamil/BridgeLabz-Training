using System;
using System.Collections.Generic;
class VehicleNode
{
    public string VehicleNumber;
    public VehicleNode Next;
    public VehicleNode(string VehicleNumber)
    {
        this.VehicleNumber = VehicleNumber;
        Next = null;
    }
}
class Roundabout
{
    private VehicleNode tail;
    public bool IsEmpty()
    {
        return tail == null;
    }
    public void AddVehicle(string number)
    {
        VehicleNode newNode = new VehicleNode(number);
        if (tail == null)
        {
            tail = newNode;
            tail.Next = tail;
        }
        else
        {
            newNode.Next = tail.Next;
            tail.Next = newNode;
            tail = newNode;
        }
        Console.WriteLine("Vehicle " + number + " entered the roundabout.");
    }
    public void RemoveVehicle()
    {
        if (tail == null)
        {
            Console.WriteLine("No vehicles in the roundabout.");
            return;
        }
        VehicleNode head = tail.Next;
        if (head == tail)
        {
            Console.WriteLine("Vehicle " + head.VehicleNumber + " exited the roundabout.");
            tail = null;
        }
        else
        {
            Console.WriteLine("Vehicle " + head.VehicleNumber + " exited the roundabout.");
            tail.Next = head.Next;
        }
    }
    public void Display()
    {
        if (tail == null)
        {
            Console.WriteLine("No vehicles in the roundabout.");
            return;
        }
        Console.Write("Vehicles in the roundabout: ");
        VehicleNode temp = tail.Next;
        do
        {
            Console.WriteLine(temp.VehicleNumber + " ");
            temp = temp.Next;
        }
        while (temp != tail.Next);
        Console.WriteLine("Back to start");
    }
}
class WaitingQueue
{
    private Queue<string> queue = new Queue<string>();
    private int capacity;
    public WaitingQueue(int capacity)
    {
        this.capacity = capacity;

    }
    public void Enqueue(string vehicle)
    {
        if (queue.Count == capacity)
        {
            Console.WriteLine("Waiting queue is full. Vehicle " + vehicle + " cannot enter.");
        }
        else
        {
            queue.Enqueue(vehicle);
            Console.WriteLine("Vehicle " + vehicle + " added to the waiting queue.");
        }
    }
    public string Dequeue()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Waiting queue is empty.");
            return null;
        }
        return queue.Dequeue();
    }
    public bool HasVehicles()
    {
        return queue.Count > 0;
    }
    public void Display()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Waiting queue is empty.");
            return;
        }
        Console.Write("Waiting queue: ");
        foreach (var vehicle in queue)
        {
            Console.Write(vehicle + " ");
        }
        Console.WriteLine();
    }
}
class TrafficManager
{
    static void Main()
    {
        TrafficManager obj = new TrafficManager();
        obj.Menu();
    }
    void Menu()
    {
        Roundabout roundabout = new Roundabout();
        Console.WriteLine("Enter the capacity of the waiting queue:");
        int capacity = int.Parse(Console.ReadLine());
        WaitingQueue waitingQueue = new WaitingQueue(capacity);
        int choice;
        do
        {
            Console.WriteLine("\n===== Traffic Manager Menu =====");
            Console.WriteLine("1. Add Vehicle to Waiting Queue");
            Console.WriteLine("2. Move Vehicle into Roundabout");
            Console.WriteLine("3. Remove Vehicle from Roundabout");
            Console.WriteLine("4. Display Roundabout");
            Console.WriteLine("5. Display Waiting Queue");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Vehicle Number: ");
                    string vehicle = Console.ReadLine();
                    waitingQueue.Enqueue(vehicle);
                    break;

                case 2:
                    if (waitingQueue.HasVehicles())
                    {
                        string v = waitingQueue.Dequeue();
                        roundabout.AddVehicle(v);
                    }
                    else
                    {
                        Console.WriteLine("No vehicles waiting.");
                    }
                    break;

                case 3:
                    roundabout.RemoveVehicle();
                    break;

                case 4:
                    roundabout.Display();
                    break;

                case 5:
                    waitingQueue.Display();
                    break;

                case 0:
                    Console.WriteLine("Exiting Traffic Manager...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;

            }
        } while (choice != 0);
    }
}