class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 1)
            return true;

        int count = 0;

        while (n > 0)
        {
            if ((n & 1) == 1)
                count++;

            n >>= 1;
        }

        return count == 1;
    }
}
