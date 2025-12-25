using System;

class GeometryUtility{
    public static double GetDistance(double x1, double y1, double x2, double y2)
    {
        double part1 = Math.Pow(x2 - x1, 2);
        double part2 = Math.Pow(y2 - y1, 2);
        double distance = Math.Sqrt(part1 + part2);
        return distance;
    }

    public static double[] GetLineEquation(double x1, double y1, double x2, double y2){
        double m = (y2 - y1) / (x2 - x1);   
        double b = y1 - m * x1;            

        double[] result = new double[2];
        result[0] = m;
        result[1] = b;

        return result;
    }
}

class Distance{
    static void Main(){
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = GeometryUtility.GetDistance(x1, y1, x2, y2);
        double[] equation = GeometryUtility.GetLineEquation(x1, y1, x2, y2);

        Console.WriteLine("\nEuclidean Distance = " + distance);
        Console.WriteLine("Slope (m) = " + equation[0]);
        Console.WriteLine("Y-Intercept (b) = " + equation[1]);

        Console.WriteLine("\nEquation of Line: y = " + equation[0] + "x + " + equation[1]);
    }
}
