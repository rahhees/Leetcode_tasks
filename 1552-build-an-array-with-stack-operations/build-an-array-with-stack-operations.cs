public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
         List<string>values = new List<string>();
         for(int i=1;i<=target[target.Length-1];i++){
            values.Add("Push");
            if(!target.Contains(i)){
                values.Add("Pop");
            }
         }
            return values;
    }
}