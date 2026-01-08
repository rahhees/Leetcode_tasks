public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
    
     
     var Set = new HashSet<int>(arr);
    

        var list = Set.ToList();
        list.Sort();

        var rank = new Dictionary<int,int>();
        int r = 1;
        foreach(var val in list){
            rank[val] = r++;
        }

        var result = new int[arr.Length];
        for(int i=0;i<arr.Length;i++){
            result[i] = rank[arr[i]];
        }
     
    return result;
    }
}