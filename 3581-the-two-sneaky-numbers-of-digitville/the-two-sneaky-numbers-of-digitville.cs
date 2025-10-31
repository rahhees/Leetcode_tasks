public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        List<int> number = new List<int>();

        for(int i = 0;i<nums.Length;i++){
            for(int j= i+1;j<nums.Length;j++){
                if(nums[i]==nums[j]){
                    if(!number.Contains(nums[i])){
                        number.Add(nums[i]);
                    }
                }
            }
        }
    return number.ToArray();
    }
}