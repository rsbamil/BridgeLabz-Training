using Newtonsoft.Json.Linq;
using System;

class IplJsonCensor
{
    static string Mask(string team)
    {
        var parts = team.Split(' ');
        parts[1] = "***";
        return string.Join(" ", parts);
    }

    static void Main()
    {
        JArray matches = JArray.Parse(System.IO.File.ReadAllText("ipl.json"));

        foreach (var m in matches)
        {
            m["team1"] = Mask(m["team1"].ToString());
            m["team2"] = Mask(m["team2"].ToString());
            m["winner"] = Mask(m["winner"].ToString());
            m["player_of_match"] = "REDACTED";
        }

        System.IO.File.WriteAllText("ipl_censored.json", matches.ToString());
    }
}
