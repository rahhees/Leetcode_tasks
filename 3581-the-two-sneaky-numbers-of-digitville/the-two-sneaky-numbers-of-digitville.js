/**
 * @param {number[]} nums
 * @return {number[]}
 */
var getSneakyNumbers = function(nums) {
let arr = []
for(let i = 0;i<nums.length;i++){
    for(let j=i+1;j<nums.length;j++){
        if(nums[i]===nums[j]){
            if(!arr.includes(nums[i])){
                arr.push(nums[i])
            }
        }
    }
}
    return arr

};