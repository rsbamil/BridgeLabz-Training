using System;

class AreaOfCircle
{
    static void Main(string[] args)
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double area = 3.14 * r * r;
        Console.WriteLine("Area of circle is " + area);
    }
}
