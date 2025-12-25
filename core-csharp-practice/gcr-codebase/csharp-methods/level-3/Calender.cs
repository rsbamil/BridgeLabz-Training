using System;

class CalendarUtility{
    public static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    public static bool IsLeapYear(int year){
        if (year % 400 == 0){
            return true;
            }
        else if (year % 100 == 0){
            return false;
            }
        else if (year % 4 == 0){
            return true;
            }
        else{
            return false;
            }
    }

    public static int GetDaysInMonth(int month, int year){
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year)){
            return 29;
            }

        return days[month - 1];
    }

    public static int GetFirstDay(int month, int year){
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
        return d0; 
    }
}

class Calender{
    static void Main(){
        Console.Write("Enter Month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        string monthName = CalendarUtility.GetMonthName(month);
        int days = CalendarUtility.GetDaysInMonth(month, year);
        int firstDay = CalendarUtility.GetFirstDay(month, year);

        Console.WriteLine("\n      " + monthName + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        for (int i = 0; i < firstDay; i++){
            Console.Write("    ");
            }

        for (int day = 1; day <= days; day++){
            Console.Write(String.Format("{0,3} ", day));

            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
