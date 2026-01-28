public class TextUtilities
{
    public string Reverse(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string input)
    {
        string rev = Reverse(input);
        return input.Equals(rev, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string input)
    {
        return input.ToUpper();
    }
}