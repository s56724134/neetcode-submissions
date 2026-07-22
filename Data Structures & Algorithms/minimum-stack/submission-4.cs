public class MinStack {
    
    private Stack<int> stack;

    public MinStack() {
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        // 要怎麼拿到最小值
        // 將stack裡的元素一個個拿出來(用Pop方法)
        // 但需要另外一個暫時的stack去裝Pop出來的元素
        // 最後在將temp裡的元素裝回stack
        Stack<int> temp = new Stack<int>();
        int mini = stack.Peek();
        while(stack.Count > 0)
        {
            mini = Math.Min(mini, stack.Peek());
            temp.Push(stack.Pop());
        }
        while(temp.Count > 0)
        {
            stack.Push(temp.Pop());
        }
        return mini;
    }
}
