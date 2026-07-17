public class Solution {
    public int MaxArea(int[] heights) {
        //用pointer
        //設置左邊索引起點為l,設置右邊的索引為r
        //並且能裝的容器要以比較小的那半邊為主
        // 不然會溢出來
        int res = 0;
        // int l = 0;
        for(int l = 0; l < heights.Length - 1; l++)
        {
            int r = l + 1;
            while(r < heights.Length)
            {
                if(heights[l] < heights[r])
                {
                    int current = heights[l] * (r - l);
                    if(current > res)
                    {
                        res = current;
                    }
                }
                else if(heights[l] > heights[r])
                {
                    int current = heights[r] * (r - l);
                    if(current > res)
                    {
                        res = current;
                    }
                }
                else
                {
                    int current = heights[r] * (r - l);
                    if(current > res)
                    {
                        res = current;
                    }
                }
                r++;
            } 
        }
        return res;
        // while(l < r)
        // {
        //     if(l == r)
        //     {
        //         return res;
        //     }
        //     if(heights[l] < heights[r])
        //     {
        //         int current = heights[l] * (r - l);
        //         Console.WriteLine(current);
        //         if(current > res)
        //         {
        //             res = current;
        //         }
               
        //     }
        //     if(heights[l] > heights[r])
        //     {
        //         int current = heights[r] * (r - l);
        //         if(current > res)
        //         {
        //             res = current;
        //         }
                
        //     }
        //     l++;
        //     r--;
        // }
        // return res;
    }
}
