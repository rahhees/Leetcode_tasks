/**
 * @param {number} n
 * @return {number}
 */
var bulbSwitch = function(n) {
    let count =1;
    while(count*count<=n){
        count++
    }
    return count-1;
};