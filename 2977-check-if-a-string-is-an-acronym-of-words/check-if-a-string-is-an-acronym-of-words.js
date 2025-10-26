/**
 * @param {string[]} words
 * @param {string} s
 * @return {boolean}
 */
var isAcronym = function(words, s) {
    let val= ""
  for(let i=0;i<words.length;i++){
   val+=words[i][0]
  }
  return val===s
    
};