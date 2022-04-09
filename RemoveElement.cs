public static int RemoveElement(int[] nums, int val)
{
    int len = nums.Length;
    for (int i = 0; i < len;)
    {

        if (nums[i] == val)
        {
            for (int j = i + 1; j < len; j++)
            {
                nums[j - 1] = nums[j];
            }
            len--;
        }
        else
        {
            i++;
        }
    }
    return len;
}