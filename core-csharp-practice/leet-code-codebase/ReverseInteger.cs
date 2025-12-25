using System;

class Solution
{
    public int Reverse(int x)
    {
        long ans = 0;

        while (x != 0)
        {
            int rem = x % 10;
            x = x / 10;
            ans = ans * 10 + rem;
        }

        if (ans > int.MaxValue || ans < int.MinValue)
        {
            return 0;
        }

        return (int)ans;
    }
}
