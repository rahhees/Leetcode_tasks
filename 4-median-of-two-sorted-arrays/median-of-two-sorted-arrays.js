/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function(nums1, nums2) {

    let val   = nums1.concat(nums2);
          val.sort((a,b)=>a-b);
    let midd = val.length;
    let middle = Math.floor(midd/2);
  
        if(midd%2===0){
            return  (val[middle-1]+val[middle])/2;
        }else{
            return val[middle]
        }
    
};