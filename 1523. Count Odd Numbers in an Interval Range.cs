public class Solution {
    public int CountOdds(int low, int high) 
    {
        if((low&1)==0){
            low++;
        }
        return high<low?0:(high-low)/2+1;
    }
}