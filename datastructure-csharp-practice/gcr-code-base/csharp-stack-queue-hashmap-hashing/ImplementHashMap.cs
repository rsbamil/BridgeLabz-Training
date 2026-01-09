using System;

class CustomHashMap
{
    // Node for Linked List
    class Node
    {
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private int size;
    private Node[] buckets;

    public CustomHashMap(int size)
    {
        this.size = size;
        buckets = new Node[size];
    }

    // Hash function
    private int GetIndex(int key)
    {
        return Math.Abs(key) % size;
    }

    // Insert or Update
    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        Node head = buckets[index];

        Node current = head;
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value; // update
                return;
            }
            current = current.Next;
        }

        // Insert at beginning
        Node newNode = new Node(key, value);
        newNode.Next = head;
        buckets[index] = newNode;
    }

    // Retrieve value
    public int Get(int key)
    {
        int index = GetIndex(key);
        Node current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;
            current = current.Next;
        }

        return -1; // Not found
    }

    // Remove key
    public void Remove(int key)
    {
        int index = GetIndex(key);
        Node current = buckets[index];
        Node prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    buckets[index] = current.Next;
                else
                    prev.Next = current.Next;
                return;
            }
            prev = current;
            current = current.Next;
        }
    }
}
class ImplementHashMap
{
    static void Main()
    {
        CustomHashMap map = new CustomHashMap(5);

        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(6, 600); // collision with key 1

        Console.WriteLine(map.Get(1)); // 100
        Console.WriteLine(map.Get(2)); // 200
        Console.WriteLine(map.Get(6)); // 600

        map.Remove(2);
        Console.WriteLine(map.Get(2)); // -1
    }
}
