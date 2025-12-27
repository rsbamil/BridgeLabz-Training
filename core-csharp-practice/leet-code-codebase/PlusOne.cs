class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length - 1;

        while (n >= 0)
        {
            if (digits[n] == 9)
            {
                digits[n] = 0;
            }
            else
            {
                digits[n] += 1;
                return digits;
            }
            n--;
        }

        int[] temp = new int[digits.Length + 1];
        temp[0] = 1;
        return temp;
    }
}
