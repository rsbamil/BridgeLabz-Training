using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text =
            "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

        // Regex explanation:
        // \b        → Word boundary (ensures full date match)
        // \d{2}     → Matches exactly 2 digits (day)
        // /         → Matches the '/' separator
        // \d{2}     → Matches exactly 2 digits (month)
        // /         → Matches the '/' separator
        // \d{4}     → Matches exactly 4 digits (year)
        // \b        → End of date boundary
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        for (int i = 0; i < matches.Count; i++)
        {
            Console.Write(matches[i].Value);
            if (i < matches.Count - 1)
                Console.Write(", ");
        }
    }
}
