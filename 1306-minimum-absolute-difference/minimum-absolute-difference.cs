public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {

        Array.Sort(arr);

        int min = int.MaxValue;
        List<IList<int>> result = new List<IList<int>>();

        for(int i =1;i<arr.Length;i++){
            min = Math.Min(min,arr[i]-arr[i-1]);
        }

        for(int i=1;i<arr.Length;i++){
            if(arr[i]-arr[i-1] == min){
                result.Add(new List<int> {arr[i-1],arr[i]});
            }
        }
        return result;
    }
}