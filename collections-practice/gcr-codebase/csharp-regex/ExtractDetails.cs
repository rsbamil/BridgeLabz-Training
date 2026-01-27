using System;
using System.Text.RegularExpressions;

class ExtractDetails
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";

        // Regex explanation:
        // [A-Za-z0-9._%+-]+  → Matches the username part of email
        // @                  → Matches '@' symbol
        // [A-Za-z0-9.-]+     → Matches domain name
        // \.                 → Matches dot '.'
        // [A-Za-z]{2,}       → Matches domain extension (com, org, net, etc.)
        string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
