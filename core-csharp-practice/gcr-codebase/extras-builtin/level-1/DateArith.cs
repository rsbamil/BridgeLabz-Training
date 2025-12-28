using System;

class DateArith
{
    static void Main()
    {
        Console.Write("Enter a date (dd/MM/yyyy): ");
        DateTime dateIn = DateTime.Parse(Console.ReadLine());

        DateTime newDate = dateIn.AddDays(7);
        newDate = newDate.AddMonths(1);
        newDate = newDate.AddYears(2);

        newDate = newDate.AddDays(-21);

        Console.WriteLine("\nFinal Date after calculations: " + newDate.ToString("dd/MM/yyyy"));
    }
}
