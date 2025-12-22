public class Solution {
    public int EarliestTime(int[][] tasks) {
        int ans = int.MaxValue;

        for(int i =0;i<tasks.Length;i++){
            int start = tasks[i][0];
            int duration = tasks[i][1];
            int finish = start+ duration;
            if(finish<ans){
                ans= finish;
            }
        }
      return ans;
}

}