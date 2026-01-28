using System;
class Rounds{
    static void Main(){
        int side1=Convert.ToInt32(Console.ReadLine());
        int side2=Convert.ToInt32(Console.ReadLine());
        int side3=Convert.ToInt32(Console.ReadLine());
        int perimeter=side1+side2+side3;
        int rounds=5000/perimeter;
        Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km");
    }
}