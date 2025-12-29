// 29-12-2025
class Solution
{
    public int SingleNumber(int[] nums)
    {
        int ans = 0;
        foreach (int a in nums)
        {
            ans = ans ^ a;
        }
        return ans;
    }
}
