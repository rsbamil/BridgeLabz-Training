using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string text =
            "Visit https://www.google.com and http://example.org for more info.";

        // Regex explanation:
        // http        → Matches 'http'
        // s?          → Matches optional 's' (http or https)
        // ://         → Matches '://'
        // [^\s,]+     → Matches one or more characters
        //               that are NOT whitespace or comma (URL body)
        string pattern = @"https?://[^\s,]+";

        MatchCollection matches = Regex.Matches(text, pattern);

        for (int i = 0; i < matches.Count; i++)
        {
            Console.Write(matches[i].Value);
            if (i < matches.Count - 1)
                Console.Write(", ");
        }
    }
}
