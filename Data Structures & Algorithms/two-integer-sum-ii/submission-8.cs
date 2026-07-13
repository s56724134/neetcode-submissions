public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //回傳一個陣列，裡面兩個元素加起來必須等於目標
        //而且第一個元素必須大於第二個元素
        //
        //用Pointers
        int l = 0; 
        int r = numbers.Length - 1;
        

        while(l < r)
        {
            int sum = numbers[l] + numbers[r];
            if(sum == target)
            {
                return new int[] { l+1, r+1 };
            }
            else if(sum > target)
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        return new int[0];
        
    }
}
