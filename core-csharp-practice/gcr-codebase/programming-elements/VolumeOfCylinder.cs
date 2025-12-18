using System;

class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius of the cylinder: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of the cylinder: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double volume = 3.14 * r * r * h;
        Console.WriteLine("Volume of cylinder is " + volume);
    }
}
