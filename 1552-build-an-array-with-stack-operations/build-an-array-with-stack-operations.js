/**
 * @param {number[]} target
 * @param {number} n
 * @return {string[]}
 */
var buildArray = function(target, n) {
   let array = [];
   for(let i=1;i<=target[target.length-1];i++){

     array.push("Push")
    if(!target.includes(i)){
        array.push("Pop")

    }
        
   }
    return array;
};