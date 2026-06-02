public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //看每一列row有沒有出現重複的元素，如果有重複的話return false
        for(int row = 0; row < 9; row++)
        {
            var seen = new HashSet<char>();
            for(int i = 0; i < 9; i++)
            {
                
                if(board[row][i] == '.') continue; 
                if(seen.Contains(board[row][i]))
                {
                    return false;
                }
                seen.Add(board[row][i]);
            }
        }
        //看每一行裡是不是有重複出現的元素，如果有的話則return false
        for(int column = 0; column < 9; column++)
        {
            var seen = new HashSet<char>();
            for(int i = 0; i < 9; i++)
            {
                
                if(board[i][column] == '.') continue;  
                if(seen.Contains(board[i][column]))
                {
                    return false;
                }
                seen.Add(board[i][column]);
            }
        }
        //找出每個小方塊中有沒有重複的數字
        //首先需要知道是落在哪一個區塊
        //落在哪一個區塊外還要知道從哪一列哪一行開始為起始點
        for(int square = 0; square < 9; square++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    int row = (square / 3) * 3 + i;
                    int column = (square % 3) * 3 + j;
                    if(board[row][column] == '.') continue;  
                    if(seen.Contains(board[row][column]))
                    {
                        return false;
                    }
                    seen.Add(board[row][column]);
                }
            }
        }
        return true;
    }
}
