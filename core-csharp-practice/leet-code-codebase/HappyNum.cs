using System;
using System.Collections.Generic;

class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> set = new HashSet<int>();

        while (n != 1 && !set.Contains(n))
        {
            set.Add(n);
            n = AddSquares(n);
        }

        return n == 1;
    }

    public int AddSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}
