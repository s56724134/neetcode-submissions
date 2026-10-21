public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //題目沒有給定s1一定會小於s2或是s2會大於s1
        if(s1.Length > s2.Length)
        {
            return false;
        }

        int[] s1Freq = new int[26];
        int[] windowFreq = new int[26];

        //第一個window
        for(int i = 0; i < s1.Length; i++)
        {
            s1Freq[s1[i] - 'a']++;
            windowFreq[s2[i] - 'a']++;
        }

        if(IsSame(s1Freq, windowFreq))
        {
            return true;
        }

        for(int r = s1.Length; r < s2.Length; r++)
        {
            //離開的元素的出現次數要扣掉
            windowFreq[s2[r - s1.Length] - 'a']--;

            //新加入的元素的出現次數要加上
            windowFreq[s2[r] - 'a']++;

            if(IsSame(s1Freq, windowFreq))
            {
                return true;
            }
        }
        return false;
    }

    private bool IsSame(int[] freq1, int[] freq2)
    {
        for(int i = 0; i < 26; i++)
        {
            if(freq1[i] != freq2[i])
            {
                return false;
            }
        }
        return true;
    }
}
