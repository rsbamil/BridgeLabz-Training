using System;

class CollinearUtility{
    public static bool IsCollinearBySlope(double x1, double y1,double x2, double y2,double x3, double y3){
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        if (slopeAB == slopeBC && slopeBC == slopeAC){
            return true;
            }
        else{
            return false;
            }
    }

    public static bool IsCollinearByArea(double x1, double y1,double x2, double y2,double x3, double y3){
        double area = 0.5 * (x1 * (y2 - y3)+ x2 * (y3 - y1)+ x3 * (y1 - y2));

        if (area == 0){
            return true;
            }
        else{
            return false;
            }
    }
}

class Collinear{
    static void Main(){
        Console.Write("Enter x1 y1: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2 y2: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3 y3: ");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        bool slopeResult = CollinearUtility.IsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = CollinearUtility.IsCollinearByArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("\nUsing Slope Method: " + slopeResult);
        Console.WriteLine("Using Area Method: " + areaResult);

        if (slopeResult && areaResult){
            Console.WriteLine("Points are COLLINEAR");
            }
        else{
            Console.WriteLine("Points are NOT Collinear");
            }
    }
}
