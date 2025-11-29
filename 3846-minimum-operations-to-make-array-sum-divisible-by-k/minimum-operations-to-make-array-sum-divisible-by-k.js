var minOperations = function(nums, k) {
    let sum = nums.reduce((acc, num) => acc + num);
    let remainder = sum % k;
    return remainder === 0 ? 0 : remainder;
};
