public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        List<bool> result = new List<bool>();
        int value = 0;
        foreach(int val in nums){
            value=(value*2+val)%5;
            result.Add(value==0);
        }
    return result;
    }
}