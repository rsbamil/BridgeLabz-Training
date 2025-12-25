using System;

class UnitConvertorProgram{
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet){
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters){
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches){
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCentimeters(double inches){
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class UnitConvertor2{
    static void Main(){
        double yards=double.Parse(Console.ReadLine());
        double feet=double.Parse(Console.ReadLine());
        double meters=double.Parse(Console.ReadLine());
        double inches=double.Parse(Console.ReadLine());
        Console.WriteLine(yards+" Yards in Feet = " + UnitConvertorProgram.ConvertYardsToFeet(yards));
        Console.WriteLine(feet+" Feet in Yards = " + UnitConvertorProgram.ConvertFeetToYards(feet));
        Console.WriteLine(meters+" Meters in Inches = " + UnitConvertorProgram.ConvertMetersToInches(meters));
        Console.WriteLine(inches+" Inches in Meters = " + UnitConvertorProgram.ConvertInchesToMeters(inches));
        Console.WriteLine(inches+" Inches in CM = " + UnitConvertorProgram.ConvertInchesToCentimeters(inches));
    }
}
