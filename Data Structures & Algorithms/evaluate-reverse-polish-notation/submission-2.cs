public class Solution {
    public int EvalRPN(string[] tokens) {
        // =====================Intuition==============================
        
        // Stack很適合用來處理Reverse Polish Notation，因為每次遇到運算子最近放入的兩個數字
        // 將是會運算的數字。
        // 依序掃描tokens:
        //  1.當我們看到數字時將數字Push到Stack裡面。
        //  2.當我們看到運算子時將Stack裡前兩個元素Pop出來運算，運算完的結果再Push回到Stack。
        
        
        // =====================Algorithm==============================
        // 1.創建空的Stack
        // 2.Foreach tokens
                // 如果是number
                    // 將這個number轉成int，並且放入stack裡面
                // 如果是運算子
                    // Pop前兩個元素去運算
                    // 且拿出來的元素順序不能跑掉
                    // 運算完後再push回stack
        // 3.跑完全部的tokens後stack應該只會剩下一個元素，將之return

        Stack<int> stack = new Stack<int>();
        foreach(string s in tokens)
        {
            if(s == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if(s == "-")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if(s == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(s == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b / a);
            }
            else
            {
                stack.Push(int.Parse(s));
            }
        }
        return stack.Pop();
        
    }
}
