using System;

class LeapYear{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Year is not a Leap Year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year");
            }
        }


            // Program using logical operator
        //     if((year%4==0 && year%100!=0 ) || year % 400 == 0)
        //     {
        //         Console.WriteLine("Year is the Leap Year");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Year  is not a Leap year");
        //     }
        // }
        else
        {
            Console.WriteLine("Year should be greater than or equal to 1582");
        }
    }
}
