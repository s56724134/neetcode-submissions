public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0;
        int res = 0;
        int[] freq = new int[26];
        int maxFreq = 0;

        for (int r = 0; r < s.Length; r++)
        {
            // 1. 加入 s[r]，更新 freq
            int index = s[r] - 'A';
            freq[index]++;
            // 2. 更新 maxFreq
            maxFreq = Math.Max(maxFreq, freq[index]);
            
            int length = r - l + 1;
            int replacement = length - maxFreq;
            // 3. 如果需要修改的次數 > k
            //    就縮小左邊的 Window
            if(replacement > k)
            {
                freq[s[l] - 'A']--;
                l++;
            }
            // 4. 更新 res
            res = Math.Max(r - l + 1, res);
        }
        return res;
    }
}
