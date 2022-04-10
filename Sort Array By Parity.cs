public class Solution
{
    //way 1
    public int[] SortArrayByParity1(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] % 2 == 0)
                left++;
            if (nums[right] % 2 != 0)
                right--;
            if (nums[left] % 2 != 0 && nums[right] % 2 == 0 && left < right)
            {
                int tmp = nums[right];
                nums[right] = nums[left];
                nums[left] = tmp;
                left++;
                right--;
            }

        }
        return nums;
    }
    //way 2
    public int[] SortArrayByParity2(int[] nums)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                int tmp = nums[index];
                nums[index++] = nums[i];
                nums[i] = tmp;

            }
        }
        return nums;
    }
}