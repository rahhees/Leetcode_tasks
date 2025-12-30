public class Solution {
    private int SumOfSquares(int n){
    int sum = 0;
    while(n>0){
        int digit = n% 10;
        sum+=digit *digit;
        n/=10;
    }
    return sum;
    }
    public bool IsHappy(int n) {
      var hash  = new HashSet<int>();

      while(n!= 1 && !hash.Contains(n)){
        hash.Add(n);
        n = SumOfSquares(n);
      }
      return n==1;
}
}