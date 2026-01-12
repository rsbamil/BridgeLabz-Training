using System;

class CustomFurniture
{
    static int MaxEarning(int length, int[] price)
    {
        if (length == 0)
            return 0;

        int max = 0;

        for (int cut = 1; cut <= length; cut++)
        {
            int earning = price[cut] + MaxEarning(length - cut, price);
            max = Math.Max(max, earning);
        }

        return max;
    }
    // Scenerio B
    static int MaxEarningWithWaste(int length, int[] price, int wasteLimit)
    {
        if (length <= wasteLimit)
            return 0;

        int max = 0;

        for (int cut = 1; cut <= length; cut++)
        {
            int earning = price[cut] +
                          MaxEarningWithWaste(length - cut, price, wasteLimit);

            max = Math.Max(max, earning);
        }

        return max;
    }
    static void Main()
    {
        int rodLength = 12;

        // Price list 
        int[] price = { 0, 2, 5, 7, 8, 10, 13, 17, 17, 20, 24, 30, 33 };


        // Scenario A
        Console.WriteLine("Scenario A - Max Earning for 12ft Rod:");
        Console.WriteLine(MaxEarning(rodLength, price));

        // Scenario B
        int wasteLimit = 1;
        Console.WriteLine("\nScenario B - Max Earning with Waste Constraint:");
        Console.WriteLine(MaxEarningWithWaste(rodLength, price, wasteLimit));

    }
}