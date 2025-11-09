public class Solution {
    public int BulbSwitch(int n) {
        
     int count =1;
     while(count*count<=n){
    count++;
    }
      return count-1;  
    }
}