public IList<int> FindDisappearedNumbers(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int j = Math.Abs(nums[i]) - 1;
        nums[j] = Math.Abs(nums[j]) * -1;
    }
    List<int> res = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
            res.Add(i + 1);
    }

    return res;
}