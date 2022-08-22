public class Solution {
    public int MaxProfit(int[] prices)
    {
        int buy=prices[0];
        int profit=0;
        for(int i=0;i<prices.Length;i++)
        {
            if(prices[i]<buy){
                buy=prices[i];
            }
            int temp=prices[i]-buy;
            profit=Math.Max(profit,temp);
        }
        return profit;
    }
}