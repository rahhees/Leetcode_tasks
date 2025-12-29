public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
        int val = nums[i];
        if(dict.ContainsKey(val)){
            if(i-dict[val]<=k){
                return true;
            }
        }
    dict[val]=i;
    }
    return false;
}
}
