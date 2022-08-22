public class Solution {
    public int DominantIndex(int[] nums) 
    {
        int index=-1;
        int maxNum=0;
        for(int i=0;i<nums.Count();i++)
        {
            if(nums[i]>maxNum)
            {
                index=i;
                maxNum=nums[i];
            }           
        }
        for(int i=0;i<nums.Count();i++)
        {
            if(nums[i]*2 >maxNum && i !=index)
            {
                return -1;
            }
        }
        return index;
    }
}