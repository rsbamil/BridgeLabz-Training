class Solution
{
    public int LengthOfLastWord(string s)
    {
        int i = s.Length - 1;
        int count = 0;

        // Skip trailing spaces
        while (i >= 0 && s[i] == ' ')
            i--;

        // Count last word length
        while (i >= 0 && s[i] != ' ')
        {
            count++;
            i--;
        }

        return count;
    }
}
