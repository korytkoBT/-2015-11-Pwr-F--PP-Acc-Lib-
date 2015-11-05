namespace BT.RecTail
  module ListOfLists =

  let rec flattenTR (aList1) = 
    let rec helpFlatt (aListRef,aAcc) =
      match aListRef with
      |h::t ->helpFlatt(t,h @ aAcc)
      |_ -> aAcc
    in helpFlatt(aList1,[])

