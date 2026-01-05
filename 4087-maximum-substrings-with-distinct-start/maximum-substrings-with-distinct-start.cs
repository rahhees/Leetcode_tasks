public class Solution {
    public int MaxDistinct(string s) {
       
        var Hash = new HashSet<char>();
        foreach(var str in s){
           Hash.Add(str);
            }
        return Hash.Count;
        }
    }
