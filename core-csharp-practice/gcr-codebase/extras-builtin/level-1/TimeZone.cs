using System;

class TimeZone
{
    static void Main()
    {
        DateTimeOffset gmt = DateTimeOffset.UtcNow;

        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(gmt, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(gmt, pstZone);

        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine("GMT (UTC) : " + gmt);
        Console.WriteLine("IST       : " + istTime);
        Console.WriteLine("PST       : " + pstTime);
    }
}
