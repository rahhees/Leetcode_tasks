var hasCycle = function(head) {
 let first = head;
 let  val = new Set();
 while(first){
    if(val.has(first)){
        return true
    }
    val.add(first);
    first = first.next
 }
 return false
 
};