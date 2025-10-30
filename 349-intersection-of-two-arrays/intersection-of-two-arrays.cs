public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2   = new HashSet<int>(nums2);

        List<int> result = new List<int>();

        foreach(int num in set1){
            if(set2.Contains(num)){
                result.Add(num);
            }
        }
        return result.ToArray();
    }
}