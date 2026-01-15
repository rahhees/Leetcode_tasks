public class Solution {
    public string DecodeMessage(string key, string message) {
        var map = new Dictionary<char,char>();

        char next = 'a';
        foreach(char c in key){

            if(c == ' ') continue;
            if(!map.ContainsKey(c)){
                
                map[c] = next;
                next++;
                if(next>'z') break;
            }
        }
                var sb = new StringBuilder();
                foreach(char c in message){
                    if(c == ' '){
                        sb.Append(' ');
                    }else{
                        sb.Append(map[c]);
                    }
                }
                return sb.ToString();
            }
        
    
}