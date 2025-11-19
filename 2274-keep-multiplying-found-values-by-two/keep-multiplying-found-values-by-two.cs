public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        int value=original;
        while(nums.Contains(value)){
            value*=2;
        }
        return value;
    }
}