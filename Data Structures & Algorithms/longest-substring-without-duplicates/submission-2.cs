public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //題目要求找出沒有重複元素的最長子字串，用twopointer來固定,
        //並且使用HashSet做為資料結構
        HashSet<char> seen = new HashSet<char>();
        int l = 0;
        int res = 0;

        for(int r = 0; r < s.Length; r++)
        {
            while(seen.Contains(s[r]))
            {
                seen.Remove(s[l]);
                l++;
            }
            seen.Add(s[r]);

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
