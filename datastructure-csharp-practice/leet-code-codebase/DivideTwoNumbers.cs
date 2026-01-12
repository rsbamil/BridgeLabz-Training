// 12-01-2026
class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        long a = Math.Abs((long)dividend);
        long b = Math.Abs((long)divisor);

        int result = BinaryDivide(a, b);

        if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0))
        {
            result = -result;
        }

        return result;
    }

    public int BinaryDivide(long a, long b)
    {
        long l = 0;
        long r = a;
        long ans = -1;

        while (l <= r)
        {
            long mid = l + (r - l) / 2;
            long mul = mid * b;

            if (mul == a)
            {
                return (int)mid;
            }
            else if (mul > a)
            {
                r = mid - 1;
            }
            else
            {
                ans = mid;
                l = mid + 1;
            }
        }

        return (int)ans;
    }
}
