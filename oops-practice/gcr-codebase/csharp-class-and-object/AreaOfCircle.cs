using System;
public class Circle
{
    int radius=2;
    public void CalculateArea()
    {
        Console.WriteLine("Area of Circle: " + (Math.PI * radius * radius));
    }
}
class AreaOfCircle
{
    static void Main()
    {
        Circle c=new Circle();
        c.CalculateArea();
    }
}