using System;
class Height{
    static void Main(){
        double height=Convert.ToDouble(Console.ReadLine());
        double totalInches = height / 2.54;
        // Calculating feet and inches
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;
        Console.WriteLine("Your Height in cm is "+height+" while in feet is "+feet+" and inches is "+inches);
    }
}