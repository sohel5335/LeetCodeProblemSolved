public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int j = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != 0 && nums[j] == 0)
            {
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                j++;
            }
            else if (nums[j] != 0)
            {
                j++;
            }
        }
    }
}