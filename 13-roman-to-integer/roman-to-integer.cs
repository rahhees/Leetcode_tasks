public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<char,int>(){
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] =1000
        };

            int total=0;
            
            for(int i=0;i<s.Length-1;i++){
                int current = dict[s[i]];
                int next = dict[s[i+1]];

                if(current<next){
                    total-=current;
                }else{
                    total+=current;
                }
            }
                total+=dict[s [s.Length-1]];
                return total;
            }
    }



        
    


