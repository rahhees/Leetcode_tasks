public class Solution {
    public int MinDeletionSize(string[] strs) {
       int rows = strs.Length;
       int col = strs[0].Length;
       int delete = 0;

       for(int i=0;i<col;i++){
        for(int j=1;j<rows;j++){
            if(strs[j][i]<strs[j-1][i]){
                delete++;
                break;
            }
        }
      
        }
        return delete;
       } 
}