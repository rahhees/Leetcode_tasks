public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var Dict = new HashSet<int>(arr2);
        var list = new List<int>();
        var Others = new List<int>();
        foreach(var item in arr1){
            if(Dict.Contains(item)){
                list.Add(item);
            }else{
                Others.Add(item);
            }
        }
        var Dicts  = new Dictionary<int,int>();
        foreach(var item in list){
               if (!Dicts.ContainsKey(item)) Dicts[item] = 0;
            Dicts[item]++;
        }

        var result = new List<int>();
        foreach(var item in arr2){
             if(Dicts.TryGetValue(item,out int count)){
                 for(int i=0;i<count;i++){
                    result.Add(item); 
                 }
             }
        }

        Others.Sort();
        result.AddRange(Others);
        return result.ToArray();
    }
}