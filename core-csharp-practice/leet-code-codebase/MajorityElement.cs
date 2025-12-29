// 29-12-2025
class Solution
{
    public int MajorityElement(int[] nums)
    {
        int point = 0;
        int leader = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (point == 0)
            {
                point = 1;
                leader = nums[i];
            }
            else if (leader != nums[i])
            {
                point--;
            }
            else
            {
                point++;
            }
        }
        return leader;
    }
}
