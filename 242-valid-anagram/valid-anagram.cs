public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] valss = s.ToCharArray();
        char[] valsss = t.ToCharArray();
        
        Array.Sort(valss);
        Array.Sort(valsss);

        string sorted1 = new string(valss);
        string sorted2 = new string(valsss);

        return sorted1==sorted2;
    }
}