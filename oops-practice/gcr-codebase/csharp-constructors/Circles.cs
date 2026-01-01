using System;
class Circle
{
    double radius;

    // Default constructor
    public Circle() : this(1.0)   // calls the parameterized constructor
    {
        // Default radius = 1.0
    }

    // Parameterized constructor
    public Circle(double r)
    {
        radius = r;
    }
    public void Area()   // method to calculate area of circle
    {
        Console.WriteLine("Area of Circle: " + (3.14 * radius * radius));
    }
}
class Circles
{
    static void Main()
    {
        Circle c = new Circle(2);
        c.Area();
    }
}