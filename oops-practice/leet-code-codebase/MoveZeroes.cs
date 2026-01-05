public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int n = nums.Length;
        int k = 0;
        int count = 0;

        // Move all non-zero elements forward
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != 0)
            {
                nums[k++] = nums[i];
            }
            else
            {
                count++;
            }
        }

        // Fill remaining positions with zero
        for (int i = n - 1; i >= n - count; i--)
        {
            nums[i] = 0;
        }
    }
}
