public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int maxProfit = profit;
        
        for(int i = 0; i < prices.Length - 1; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                profit = prices[j] - prices[i];
                maxProfit = Math.Max(profit, maxProfit);
            }
        }

        return maxProfit;
    }
}
