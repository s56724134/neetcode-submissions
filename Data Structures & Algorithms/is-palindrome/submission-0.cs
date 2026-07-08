public class Solution {
    public bool IsPalindrome(string s) {
        //需要順著以及倒過來都要是同一句話
        //並且不區分大小寫之外還需要將空格去掉
        string newStr = "";
        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                newStr += char.ToLower(c);
            }
        }
        return newStr == new String(newStr.Reverse().ToArray());
    }
}
