public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //需要兩個pointer來記錄走到哪一個索引
        //走到的索引不能超過陣列的長度
        // int left = 0;
        // int right = 0;
        // for(int i = 0; i < nums.Count; i++)
        // {
        // }
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int prod = 1;
            for(int j = 0; j < nums.Length; j++)
            {
                if(i != j)
                {
                    prod *= nums[j];
                }
            }
            res[i] = prod;
        }
        return res;
    }
}
