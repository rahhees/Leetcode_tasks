public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        var Hash = new HashSet<char>(allowed);
        int Count =0;
        foreach(var item in words){
            bool Ok = true;

            foreach(var ch in item){
            if(!Hash.Contains(ch)){
                Ok = false;
                break;
            }
        }
        if(Ok){
                Count++;
        }
        }
    return Count;
    }
}