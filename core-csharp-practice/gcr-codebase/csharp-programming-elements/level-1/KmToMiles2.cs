using System;
class KmToMiles2{
    static void Main(){
        double km=Convert.ToDouble(Console.ReadLine());
        double miles=km*0.621371;
        Console.WriteLine("The total miles is "+miles+" mile for the given "+km +" km");
    }
}