public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        var Dict = new Dictionary<int,int>();

        foreach(int x in nums1){
            if(Dict.ContainsKey(x)){
                Dict[x]++;
            }else{

            Dict[x] = 1;
            }
        }

        var Result = new List<int>();

        foreach(int x in nums2){
            if(Dict.ContainsKey(x) && Dict[x]>0){
                Result.Add(x);
                Dict[x]--;
            }
        }

        return Result.ToArray();
    }


}