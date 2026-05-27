public class Solution {

    public string Encode(IList<string> strs) {
        //要注意字串裡會有逗號
        if(strs.Count == 0) return "";
        string res = "";
        foreach(string s in strs)
        {
            res += s.Length.ToString() + ",";
        }
        res += "#";
        foreach(string s in strs)
        {
            res += s;
        }
        return res;
                                                                    
    }

    public List<string> Decode(string s) {
        //如果現在s = "5,5,#helloworld"
        //必須要依靠前面的數字來裁切解析成什麼樣的字串
        //要有資料結構儲存目前的數字
        //而且是要迴圈遍歷整個s到h時依靠目前所在的索引往後裁切所需的長度
        if(s.Length == 0)
        {
            return new List<string>();
        }

        List<string> res = new List<string>();
        List<int> size = new List<int>();
        
        int i = 0;
        while(s[i] != '#')
        {
            string num = "";
            while(s[i] != ',')
            {
                num += s[i];
                i++;
            }
            size.Add(int.Parse(num));
            i++;
        }
        i++;
        foreach(int sz in size)
        {
            res.Add(s.Substring(i, sz));
            i += sz;
        }
        return res;
   }
}
