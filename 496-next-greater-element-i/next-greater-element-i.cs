public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
       var next = new Dictionary<int,int>();
       var Stack = new Stack<int>();

       foreach(var item in nums2){
        while(Stack.Count>0 && item>Stack.Peek()){
            next[Stack.Pop()] = item;
        }
        Stack.Push(item);
       }
        while(Stack.Count>0){
            next[Stack.Pop()] =-1;
        }
        var result = new int[nums1.Length];
        
        for(int i=0;i<nums1.Length;i++){
            result[i] = next[nums1[i]];
        }
        return result;
       
    }
}