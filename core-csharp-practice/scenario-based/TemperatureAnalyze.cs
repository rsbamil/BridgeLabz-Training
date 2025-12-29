using System;
class TemperatureAnalyze
{
    static string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
    static void Main()
    {
        TemperatureAnalyze obj = new TemperatureAnalyze();
        float[,] temperatures = obj.Input();
        // Find Hottest and Coldest Day
        obj.HottestDay(temperatures);
        obj.ColdestDay(temperatures);
        obj.AverageTempPerDay(temperatures);

    }
    float[,] Input()
    {
        float[,] temperatures = new float[7, 24];
        Random r = new Random();  // For taking random temperatures
        // Input: Read temperatures from the user
        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                temperatures[day, hour] = r.Next(1, 51);  // Taking random temperatures between 1 and 50
            }
        }
        return temperatures;
    }
    void HottestDay(float[,] temperatures)
    {
        float maxTemp = float.MinValue;
        int hottestDayIndex = -1;
        for (int day = 0; day < 7; day++)
        {
            float dailyMax = float.MinValue;
            for (int hour = 0; hour < 24; hour++)
            {
                if (temperatures[day, hour] > dailyMax)
                {
                    dailyMax = temperatures[day, hour];
                }
            }
            if (dailyMax > maxTemp)
            {
                maxTemp = dailyMax;
                hottestDayIndex = day;
            }
        }
        Console.WriteLine("Hottest Day: " + days[hottestDayIndex] + " with temperature: " + maxTemp);
    }
    void ColdestDay(float[,] temperatures)
    {
        float minTemp = float.MaxValue;
        int coldestDayIndex = -1;
        for (int day = 0; day < 7; day++)
        {
            float dailyMin = float.MaxValue;
            for (int hour = 0; hour < 24; hour++)
            {
                if (temperatures[day, hour] < dailyMin)
                {
                    dailyMin = temperatures[day, hour];
                }
            }
            if (dailyMin < minTemp)
            {
                minTemp = dailyMin;
                coldestDayIndex = day;
            }
        }
        Console.WriteLine("Coldest Day: " + days[coldestDayIndex] + " with temperature: " + minTemp);
    }
    void AverageTempPerDay(float[,] temperatures)
    {
        // we have to calculate average temperature per day
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;
            for (int hour = 0; hour < 24; hour++)
            {
                sum += temperatures[day, hour];
            }
            float avg = sum /(float)24;
            Console.WriteLine("Average temperature for " + days[day] + " is: " + avg);
        }
    }
}