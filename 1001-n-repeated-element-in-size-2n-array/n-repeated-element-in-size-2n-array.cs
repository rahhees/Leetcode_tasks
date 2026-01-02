public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var dict = new HashSet<int>();

       foreach(var no in nums){
            if(dict.Contains(no)){
                return no;
            }

             dict.Add(no);
    }
       return -1;
    }
 }
