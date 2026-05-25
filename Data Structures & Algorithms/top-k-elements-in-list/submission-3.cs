public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //對nums陣列跑回圈
        //如果nums裡的元素是第一次出現
        //則把它加入到Dict.key中，並且Dict.Value++
        //最後將值排序
        //找出現最多頻率的前k個
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = 1;
            }
            else
            {
                dict[nums[i]]++;
            }
        }
        return dict
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
        
    }
}
