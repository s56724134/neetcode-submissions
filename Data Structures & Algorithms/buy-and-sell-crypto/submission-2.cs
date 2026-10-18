public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int l = 0, r = 1;

        while(r < prices.Length)
        {
            if(prices[r] > prices[l])
            {
                int profit = prices[r] - prices[l];
                maxP = Math.Max(maxP, profit);
            }
            else
            {
                l = r;
            }
            r++;
        }
        return maxP;
    

    }
}
