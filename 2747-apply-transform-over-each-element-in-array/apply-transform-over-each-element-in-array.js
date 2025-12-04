var map = function(arr, fn) {
    const mappedArray=[]
        for(let i=0;i<arr.length;i++){
            const result = fn(arr[i],i)
            mappedArray.push(result)
        }
        return mappedArray
};