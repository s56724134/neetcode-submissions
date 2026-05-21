public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // 找出字串相同的元素，且數量要一致
        // 如果有相同的元素則裝入在同一個陣列
        //=========================================
        // 資料結構的選擇
        // 解法是運用Dict來解，必須知道每一個字串出現幾次，那出現幾次的key值就用要進行分類用
        // 要記錄每一個字元出現的次數可以使用ASCII編碼表的技巧
        var res = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            int[] count = new int[26];
            foreach(char c in s)
            {
                count[c - 'a']++;
            }
            string key = string.Join(',', count);
            if(!res.ContainsKey(key))
            {
                res[key] = new List<string>();
            }
            res[key].Add(s);
            
        }
        return res.Values.ToList();

        
    }
}
