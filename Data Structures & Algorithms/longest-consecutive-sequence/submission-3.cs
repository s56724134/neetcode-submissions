public class Solution {
    public int LongestConsecutive(int[] nums) {
        //因為input可能有重複的數字所以用HashSet去接
        //要有一個變數可以接連續consecutive的長度 
        int res = 0;
        var store = new HashSet<int>(nums);
        foreach(int num in nums)
        {
            int streak = 0, curr = num;
            while(store.Contains(curr))                        
            {
                streak++;
                curr++;                
            }
            res = Math.Max(res, streak);
        }
        return res;
    }
}
