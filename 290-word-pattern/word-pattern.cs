public class Solution {
    public bool WordPattern(string pattern, string s) {

        var words = s.Split(" ");

        if(pattern.Length != words.Length)
            return false;
        
        var CharToWord = new Dictionary<char,string>();
        var WordToChar = new Dictionary<string,char>();

        for(int i=0;i<pattern.Length;i++){
            char c = pattern[i];
            string word =words[i];

            if(CharToWord.ContainsKey(c)){
                if(CharToWord[c] != word)
                    return false;
                }
                
                else{
                    if(WordToChar.ContainsKey(word))
                        return false;

                        CharToWord[c] = word;
                        WordToChar[word] = c;
                    }
                }
            
        
    return true;
    }
}