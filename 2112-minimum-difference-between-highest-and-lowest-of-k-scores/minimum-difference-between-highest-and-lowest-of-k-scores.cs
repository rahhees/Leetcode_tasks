public class Solution {
    public int MinimumDifference(int[] nums, int k) {

        if(k==1){
            return 0;
        }

        Array.Sort(nums);

        int mindiff = int.MaxValue;

    
           for(int i=0;i<=nums.Length-k;i++){
        
            int diff = nums[i+k-1] - nums[i];

            mindiff = Math.Min(mindiff,diff);
        }
        return mindiff;
    }
}