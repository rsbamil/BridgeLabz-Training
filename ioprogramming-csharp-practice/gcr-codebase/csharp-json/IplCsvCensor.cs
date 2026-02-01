using System;
using System.IO;

class IplCsvCensor
{
    static string Mask(string team)
    {
        var p = team.Split(' ');
        p[1] = "***";
        return string.Join(" ", p);
    }

    static void Main()
    {
        var lines = File.ReadAllLines("ipl.csv");
        using var sw = new StreamWriter("ipl_censored.csv");

        sw.WriteLine(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            var c = lines[i].Split(',');
            c[1] = Mask(c[1]);
            c[2] = Mask(c[2]);
            c[5] = Mask(c[5]);
            c[6] = "REDACTED";
            sw.WriteLine(string.Join(",", c));
        }
    }
}
