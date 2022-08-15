public class Solution {
    public int MaximumWealth(int[][] accounts) 
    {
        int richestCusWealth=0;
        int len=accounts.Length;
        
        for(int i=0;i<len;i++)
        {
            int temp =0;
            for(int j=0;j<accounts[i].Length;j++)
            {
                temp +=accounts[i][j];
            }
            richestCusWealth=Math.Max(temp,richestCusWealth);
            
        }
        return richestCusWealth;
    }
}