public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int Total =0;
        foreach(int x in apple)
            Total+=x;
        Array.Sort(capacity);
        Array.Reverse(capacity);

        int used = 0;
        for(int i=0;i<capacity.Length;i++){
            Total-=capacity[i];
            used++;
            
            if(Total<=0)
            return used;
            
        }
        return used;
        
    }
}