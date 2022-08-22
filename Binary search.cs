public class Solution {
    public int Search(int[] nums, int target) 
    {
        
        int start=0 ;
        int end =nums.Length-1;
     
        
        while(start<=end)
        {
            int mid =(start+end)/2;
            if(target==nums[mid]) return  mid;
            if(nums[mid]<target)
                start =mid+1;
            else if(nums[mid]>target)
                end =mid-1;
        }
        
        return -1;
    }
}