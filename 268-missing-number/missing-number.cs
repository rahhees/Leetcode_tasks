public class Solution {
    public int MissingNumber(int[] nums) {

        int len = nums.Length;
        var Dict = new HashSet<int>();


        foreach(int item in nums){
            Dict.Add(item);
        }

        for(int i=0;i<=len;i++){
            if(!Dict.Contains(i)){
                return i;
            }
        }
          
        return -1;
    }
}