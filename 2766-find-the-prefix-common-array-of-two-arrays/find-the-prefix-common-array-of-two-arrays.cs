public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int n = A.Length;
        int[] result = new int[n];
        var dict = new Dictionary<int,int>();
        int common = 0;
        for(int i = 0;i<n;i++){
            int x = A[i];
            int y = B[i];
            if(!dict.ContainsKey(x)){
                dict[x] = 0;
            }
                dict[x]++;
                if(dict[x]==2){
                    common++;
                }
                if(!dict.ContainsKey(y)){
                    dict[y]=0;
                }
                    dict[y]++;
                    if(dict[y]==2){
                        common++;
                    }
                    result[i] = common;
                
            }
        

        return result;
    }
}