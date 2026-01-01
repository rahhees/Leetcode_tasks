public class Solution {
    public int[] PlusOne(int[] digits) {
    //     int sum = 0;
        
    //   for(int i=0;i<digits.Length;i++){
    //     sum+=digits[i];
    //   }
    //     int total = sum+1;
    //     int[] result = { total }; 
    // return result; 

    for(int i=digits.Length-1;i>=0;i--){
        if(digits[i]<9){
            digits[i]++;
            return digits;
        }
        digits[i]=0;
    }

    int[] result = new int[digits.Length+1];
    result[0]=1;
    return result;

   }
}