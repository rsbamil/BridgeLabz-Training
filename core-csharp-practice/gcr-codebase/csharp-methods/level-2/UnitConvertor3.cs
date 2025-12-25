using System;

class UnitConvertorProgram{
    public static double ConvertFarhenheitToCelsius(double farhenheit){
        double farhenheit2celsius = (farhenheit - 32) * 5 / 9;
        return farhenheit2celsius;
    }

    public static double ConvertCelsiusToFarhenheit(double celsius){
        double celsius2farhenheit = (celsius * 9 / 5) + 32;
        return celsius2farhenheit;
    }

    public static double ConvertPoundsToKilograms(double pounds){
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms){
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons){
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters){
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class UnitConvertor3{
    static void Main(){
        double fah=double.Parse(Console.ReadLine());
        double cel=double.Parse(Console.ReadLine());
        double pounds=double.Parse(Console.ReadLine());
        double kg=double.Parse(Console.ReadLine());
        double gallons=double.Parse(Console.ReadLine());
        double liters=double.Parse(Console.ReadLine());
        Console.WriteLine(fah+" F in Celsius = " + UnitConvertorProgram.ConvertFarhenheitToCelsius(fah));
        Console.WriteLine(cel+" C in Fahrenheit = " + UnitConvertorProgram.ConvertCelsiusToFarhenheit(cel));
        Console.WriteLine(pounds+" Pounds in Kg = " + UnitConvertorProgram.ConvertPoundsToKilograms(pounds));
        Console.WriteLine(kg+" Kg in Pounds = " + UnitConvertorProgram.ConvertKilogramsToPounds(kg));
        Console.WriteLine(gallons+" Gallons in Liters = " + UnitConvertorProgram.ConvertGallonsToLiters(gallons));
        Console.WriteLine(liters+" Liters in Gallons = " + UnitConvertorProgram.ConvertLitersToGallons(liters));
    }
}
