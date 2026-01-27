using System;
using System.Text.RegularExpressions;

class ExtractCapitalWords
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        // Regex explanation:
        // \b        → Word boundary (start/end of a word)
        // [A-Z]     → Matches one uppercase letter (A to Z)
        // [a-z]*    → Matches zero or more lowercase letters
        // \b        → Ensures the word ends properly
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
    }
}
