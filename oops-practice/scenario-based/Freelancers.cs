using System;
class Freelancers
{
    static void Main()
    {
        Freelancers freelancer = new Freelancers();
        Console.WriteLine("ENTER AN INVOICE:");
        string invoice = Console.ReadLine();
        string[] tasks = freelancer.ParseInvoice(invoice);
        int total = freelancer.GetTotalAmount(tasks);
        Console.WriteLine("TOTAL AMOUNT: " + total);
    }
    string[] ParseInvoice(string invoice)
    {
        string[] tasks = invoice.Split(',');
        string[] taskName = new string[tasks.Length];
        for (int i = 0; i < tasks.Length; i++)
        {
            taskName[i] = tasks[i].Trim();
        }
        for(int i=0;i<taskName.Length;i++)
        {
            Console.WriteLine("TASK " + (i + 1) + ": " + taskName[i]);
        }
        return taskName;
    }
    int GetTotalAmount(string[] tasks)
    {
        int total = 0;
        foreach (string task in tasks)
        {
            string[] part = task.Trim().Split('-');
            string taskPrice = part[1].Trim();
            string[] amount = taskPrice.Split(' ');
            total += int.Parse(amount[0]);
        }
        return total;
    }
}