public class Solution {
    public int Search(int[] nums, int target) {
        // ====================Intution====================
        // 題目給定的陣列是由小到大的排序
        // 如果用迴圈一個個取那麼時間複雜度會是O(N)
        // 採用Binary Search時間複雜達度會是O(logn)

        // ====================Algorithm====================
        // 1.創建一個左指標l pointer => 0
        // 2.創建一個右指標r pointer => nums.Count - 1
        // while(l <= r)
            // m = l + (l - r) / 2
            // if m > target
                // r = m - 1
            // else if m < target
                // l = m + 1
            // else
                // retrun m
        // 最後回傳-1

        int l = 0;
        int r = (nums.Length - 1);
        while(l <= r)
        {
            int m = l + ((r-l) / 2);
            if(nums[m] > target)
            {
                r = m - 1;
            }
            else if(nums[m] < target)
            {
                l = m + 1;
            }
            else
            {
                return m;
            }
        }
        return -1;
    }
}
