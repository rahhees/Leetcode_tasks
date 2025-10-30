var intersection = function(nums1, nums2) {
    let str = new Set(nums1);
    let string = new Set(nums2);
    let result = []
    
   for(let num of str){
    if(string.has(num)){
        result.push(num)
    }
   }
   return result
};