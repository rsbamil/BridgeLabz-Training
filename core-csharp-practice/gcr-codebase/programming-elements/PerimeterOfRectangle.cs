using System;

class PerimeterOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of the rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (length + breadth);
        Console.WriteLine("Perimeter of Rectangle is " + perimeter);
    }
}
