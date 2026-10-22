public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = 0;
        
        // 找出最大的一堆香蕉
        foreach (int pile in piles)
        {
            r = Math.Max(r, pile);
        }

        int res = r;

        while(l <= r)
        {
            int mid = l + (r - l) / 2;

            long totalHours = 0;

            foreach(int pile in piles)
            {
                totalHours += (pile - 1) / mid + 1;
            }
            
            if(totalHours <= h)
            {
                res = mid;

                r = mid - 1;

            }
            else
            {
                l = mid + 1;
            }
        }
        return res;
    }
}
