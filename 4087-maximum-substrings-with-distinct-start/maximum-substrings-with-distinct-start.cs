public class Solution {
    public int MaxDistinct(string s) {
       
        var Hash = new HashSet<char>(s);
     
        return Hash.Count;
        }
    }
