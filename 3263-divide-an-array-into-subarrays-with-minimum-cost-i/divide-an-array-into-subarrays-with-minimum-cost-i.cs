public class Solution {
    public int MinimumCost(int[] nums) {
        int first = nums[0];
        int smallest = int.MaxValue;
        int secondsmall = int.MaxValue;

        for(int i=1;i<nums.Length;i++){
          int x = nums[i];
          if(x<smallest){
            secondsmall = smallest;
            smallest = x;
          }else if(x<secondsmall){
            secondsmall = x;
          }
        }
    return first +smallest+secondsmall;
    }
}