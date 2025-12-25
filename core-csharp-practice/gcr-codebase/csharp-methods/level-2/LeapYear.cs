using System;

class LeapYear{
    static void Main(){
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582){
            Console.WriteLine("Leap Year program works only for year 1582 and above.");
            return;
        }

        bool result = leapYear(year);

        if (result){
            Console.WriteLine("Year is a Leap Year.");
        }
        else{
            Console.WriteLine("Year is NOT a Leap Year.");
        }
    }

    static bool leapYear(int year){
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0){
            return true;
        }
        return false;
    }
}
