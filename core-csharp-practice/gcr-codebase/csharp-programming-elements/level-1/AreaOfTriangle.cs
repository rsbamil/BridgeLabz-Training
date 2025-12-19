using System;
class AreaOfTriangle{
    static void Main(){
        double b=Convert.ToDouble(Console.ReadLine());
        double h=Convert.ToDouble(Console.ReadLine());
        double area=0.5*b*h;
        Console.WriteLine("The area of triangle is "+area);
    }
}