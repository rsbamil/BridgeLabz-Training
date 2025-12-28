using System;
using System.Globalization;

class DateComp
{
    static void Main()
    {
        Console.Write("Enter first date (dd/MM/yyyy): ");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter second date (dd/MM/yyyy): ");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        int result = DateTime.Compare(date1, date2);

        if (result < 0)
            Console.WriteLine("First date is BEFORE second date");
        else if (result > 0)
            Console.WriteLine("First date is AFTER second date");
        else
            Console.WriteLine("Both dates are SAME");
    }
}
