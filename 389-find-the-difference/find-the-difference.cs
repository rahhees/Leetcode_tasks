public class Solution {
    public char FindTheDifference(string s, string t) {
        var dict = new Dictionary<char,int>();
       
       foreach(char item in s){
        if(dict.ContainsKey(item)){
            dict[item]++;
        }else{
            dict[item]=1;
        }
       }
       foreach(char item in t){
        if(dict.ContainsKey(item)){
            dict[item]--;
        }else{
            dict[item]=-1;
        }
        if(dict[item]<0){
            return item;
        }
       }
        return '\0';
}
}