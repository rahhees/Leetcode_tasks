public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        
        var Dict = new Dictionary<int,List<int>>();
        var list = new List<IList<int>>();

        for(int i=0;i<groupSizes.Length;i++){
            int size = groupSizes[i];
            if(!Dict.ContainsKey(size)){
                Dict[size] =new List<int>();
            }
                Dict[size].Add(i);

            if(Dict[size].Count==size ){
                list.Add(new List<int> (Dict[size]));
                Dict[size].Clear();
            }
        }
        return list;
    }
}