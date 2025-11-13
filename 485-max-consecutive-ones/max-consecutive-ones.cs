public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int maxCount = 0;
        foreach(int num in nums){
            if(num==1){
                count++;
                maxCount=Math.Max(maxCount,count);
            }else{
                count=0;
            }
        }
        return maxCount;
    }
}