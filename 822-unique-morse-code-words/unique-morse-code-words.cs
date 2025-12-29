public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] sol = new string[]{
             ".-","-...","-.-.","-..",".","..-.","--.",
            "....","..",".---","-.-",".-..","--","-.",
            "---",".--.","--.-",".-.","...","-","..-",
            "...-",".--","-..-","-.--","--.." 
        };
        var uniq = new HashSet<string>();
        foreach(var word in words ){
            var sb = new StringBuilder();
            foreach(char c in word){
                sb.Append(sol[c-'a']);
            }
            uniq.Add(sb.ToString());
        }
    return uniq.Count;
    }
}