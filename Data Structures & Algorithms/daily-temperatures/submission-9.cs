public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // ===================Intution=====================
        // 將陣列裡頭的每一個元素拿出來與後面的元素做比較
        // 找出幾天後會遇到比今天更熱的溫度
        // ===================Alogorithm=====================
        // 1.創建一個空的陣列
        // 2.For迴圈i拿取每一天的溫度:
            // 創建一個stack裡面裝Dictionary
            // For迴圈j與當天後的溫度比較:
                // 如果遇到第一個比當天溫度還熱的天氣
                    // 將空陣列append(j-i)
                // 如果沒有
                    // 則append(0)
        // 3.最後將list return
        
        List<int> store = new List<int>();
        for(int i = 0; i < temperatures.Length; i++)
        {
            int days = 0;
            for(int j = i + 1; j < temperatures.Length; j++)
            { 
                if(temperatures[j] > temperatures[i])
                {
                    days = j - i;
                    break;   
                }
                
            }
            store.Add(days);
        }
        return store.ToArray();
                            
    }
}
