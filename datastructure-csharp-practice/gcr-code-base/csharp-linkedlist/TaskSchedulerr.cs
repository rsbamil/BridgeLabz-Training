using System;

// Task node
class TaskNode
{
    public int TaskId;
    public string TaskName;
    public TaskNode Next;

    public TaskNode(int id, string name)
    {
        TaskId = id;
        TaskName = name;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head = null;

    // Add task at end
    public void AddTask(int id, string name)
    {
        TaskNode node = new TaskNode(id, name);

        if (head == null)
        {
            head = node;
            node.Next = head; // circular link
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    // Display tasks
    public void DisplayTasks()
    {
        if (head == null) return;

        TaskNode temp = head;
        do
        {
            Console.WriteLine(temp.TaskId + " " + temp.TaskName);
            temp = temp.Next;
        }
        while (temp != head);
    }
}

class TaskSchedulerr
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTask(1, "Coding");
        scheduler.AddTask(2, "Testing");

        scheduler.DisplayTasks();
    }
}