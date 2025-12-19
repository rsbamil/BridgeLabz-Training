using System;
class SideOfSquare{
    static void Main(){
        double perimeter = Convert.ToDouble(Console.ReadLine());
        double side =perimeter/4;
        Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter);
    }
}