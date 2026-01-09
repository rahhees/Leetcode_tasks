public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {

     int n = grid.Length;
     int size = n * n;
     
     var freq = new Dictionary<int,int>();
     for(int i =0 ;i<n;i++){
        for(int j=0;j<n;j++){
            int val = grid[i][j];
            if(!freq.ContainsKey(val)) freq[val] = 0;
            freq[val]++;
        }
     }
            
            int repeated = -1;
            int missing = -1;

            for(int k=0;k<=size;k++){
                int count = freq.ContainsKey(k)?freq[k] :0;

                if(count==2)    repeated=k;
                else if(count ==0)  missing=k;
            }
        
     return new int[] {repeated,missing};
     }
     }

