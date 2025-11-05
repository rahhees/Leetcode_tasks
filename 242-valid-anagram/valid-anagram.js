var isAnagram = function(s, t) {
    let sortt = s.split('').sort().join();
    let sottt = t.split('').sort().join();
    return sortt==sottt
};