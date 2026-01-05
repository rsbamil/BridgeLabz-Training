public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int xor = 0;

        // XOR all numbers from 0 to n
        for (int i = 0; i <= n; i++)
        {
            xor ^= i;
        }

        // XOR all elements of the array
        for (int i = 0; i < n; i++)
        {
            xor ^= nums[i];
        }

        return xor;
    }
}
