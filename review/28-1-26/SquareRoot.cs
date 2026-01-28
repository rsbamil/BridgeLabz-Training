using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

class LinkedList
{
    public Node head;
    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = newNode;
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("NULL");
    }
}

class LLSqrt
{
    static Node GetMiddle(Node start, Node end)
    {
        Node slow = start;
        Node fast = start;

        while (fast != end && fast.next != end)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
    public static int SquareRoot(Node head, int number)
    {
        Node start = head;
        Node end = null;
        int ans = 0;
        bool found = false;
        while (start != end)
        {
            Node mid = GetMiddle(start, end);
            int square = mid.data * mid.data;
            if (square == number)
            {
                found = true;
                Console.Write("Square root found :");
                return mid.data;
            }
            else if (square < number)
            {
                ans = mid.data;
                start = mid.next;
            }
            else
            {
                end = mid;
            }
        }
        if (!found)
        {
            Console.WriteLine("There is no square root of a number present in this linked list");
            Console.Write("Its Nearest Square root is :");
            return ans;
        }
        return ans;
    }
}

class SquareRoot
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        for (int i = 1; i <= 10; i++)
        {
            list.InsertAtEnd(i);
        }
        list.Display();
        Console.WriteLine("ENTER THE NUMBER");
        int number = int.Parse(Console.ReadLine());
        int result = LLSqrt.SquareRoot(list.head, number);
        Console.Write(result);
    }
}
