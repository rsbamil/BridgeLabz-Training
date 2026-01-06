using System;
class CallLogs
{
    public string phoneNumber;
    public string message;
    public DateTime timestamp;
    public CallLogs(string phoneNumber, string message)
    {
        this.phoneNumber = phoneNumber;
        this.message = message;
        timestamp = DateTime.Now;
    }
    public void DisplayLog()
    {
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Timestamp: " + timestamp);
        Console.WriteLine("----------------------------------");
    }
}
class CallLogManager
{
    CallLogs[] logs;
    int idx = 0;
    public CallLogManager(int size)
    {
        logs = new CallLogs[size];
    }
    public void AddCallLog(string phoneNumber, string message)
    {
        if (idx < logs.Length)
        {
            logs[idx++] = new CallLogs(phoneNumber, message);
            Console.WriteLine("\nCall log added successfully.\n");
        }
        else
        {
            Console.WriteLine("Call log is full. Cannot add more logs.\n");
        }
    }
    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine("\nSearch Results for keyword: " + keyword);
        Console.WriteLine("----------------------------------");
        bool isFound = false;
        foreach (CallLogs log in logs)
        {
            if (log != null && log.message.Contains(keyword))
            {
                log.DisplayLog();
                isFound = true;
            }
        }
        if (!isFound)
        {
            Console.WriteLine("\nNo call logs found containing the keyword: " + keyword);
        }
    }
    public void FilterByTime(DateTime from, DateTime to)
    {
        Console.WriteLine("\nCall Logs from " + from + " to " + to);
        Console.WriteLine("----------------------------------");
        bool isFound = false;
        foreach (CallLogs log in logs)
        {
            if (log != null && log.timestamp >= from && log.timestamp <= to)
            {
                log.DisplayLog();
                isFound = true;
            }
        }
        if (!isFound)
        {
            Console.WriteLine("No call logs found in the specified time range.");
        }
    }
    public void DisplayAllLogs()
    {
        Console.WriteLine("\nAll Call Logs:\n");
        foreach (CallLogs log in logs)
        {
            if (log != null)
            {
                log.DisplayLog();
            }
        }
    }
}
class CustomerService
{
    static void Main()
    {
        Console.WriteLine("\nEnter maximum number of call logs to track:\n");
        int size = int.Parse(Console.ReadLine());
        CallLogManager manager = new CallLogManager(size);
        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search By Keyword");
            Console.WriteLine("3. Filter By Time Range");
            Console.WriteLine("4. Display All Logs");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Phone Number: ");
                    string phone = Console.ReadLine();

                    Console.Write("Enter Message: ");
                    string msg = Console.ReadLine();

                    manager.AddCallLog(phone, msg);
                    break;

                case 2:
                    Console.Write("Enter keyword to search: ");
                    string key = Console.ReadLine();

                    manager.SearchByKeyword(key);
                    break;

                case 3:
                    Console.Write("Enter FROM time (yyyy-MM-dd HH:mm:ss): ");
                    DateTime from = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter TO time (yyyy-MM-dd HH:mm:ss): ");
                    DateTime to = DateTime.Parse(Console.ReadLine());

                    manager.FilterByTime(from, to);
                    break;

                case 4:
                    manager.DisplayAllLogs();
                    break;

                case 5:
                    Console.WriteLine("Exiting system...");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}