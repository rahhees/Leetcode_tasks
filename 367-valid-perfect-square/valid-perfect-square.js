
var isPerfectSquare = function(num) {
    let left = 1;
    let right = num;


    while(left<=right){
       let result = Math.floor((left+right)/2);
        let square = result*result;
        if(square==num){
            return true
        }else if(square<num){
            left=result+1;
        }else{
            right=result-1;
        }
    }
        return false
};