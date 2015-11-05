namespace BT.Matcher
    module List =

    let isPalindromeM aList1 = 
      match aList1 with
        |[] -> true
        |goal when goal = List.rev aList1 -> true
        |_ -> false
    
    let rec countM (aElement, aList1) = 
      match aList1 with
        |[] -> 0
        |head::tail -> 
          match head with 
          | el when el = aElement -> 1 + countM(aElement,tail)
          | _ -> countM(aElement,tail)
        
    let rec lengthM aList1 = 
      match aList1 with
      |head::tail -> 1 + lengthM tail
      |[] -> 0
    
    let rec sqrM aList1 =
      match aList1 with
      |head::tail -> head*head::sqrM tail
      |[] -> []
    
    let rec appendM aList1 aList2 =
      match aList1 with
      |[] -> aList2
      |mHead::mTail -> mHead::appendM mTail aList2
    
    let rec sumM (aList1: float list) =
      match aList1 with 
      |h::t -> h + sumM t
      |[] -> 0.0
    
    let rec toStringM aList1 aSep =
      match aList1 with
      |h::t when t=[] -> h+""
      |h::t -> h+aSep+( toStringM t aSep ) 
      |[] -> ""
    
    let rec mniejszeM aList1 aElement = 
      match aList1 with
      |h::t when h<aElement -> true && mniejszeM t aElement
      |[] -> true
      |_ -> false
    
    let rec mniejszeM2 aList aValue = 
      match aList with
      |h::t when h<aValue -> true && mniejszeM t aValue
      |h::t when h>=aValue -> false
      |_ -> true
    
    let rec genListM aLowerLimIncl aHigherLimIncl =
      match aLowerLimIncl with
      | _ when aLowerLimIncl<>aHigherLimIncl -> aLowerLimIncl :: genListM (aLowerLimIncl+1) aHigherLimIncl
      | _ when aLowerLimIncl= aHigherLimIncl -> aHigherLimIncl::[]
      | _  -> []
    
    let rec podzielM aList1 =
      let rec innerHelp (aEvenAcc,aOddAcc,aList1)=
        match aList1 with 
        |h::t when h % 2 =0 -> innerHelp(h::aEvenAcc,aOddAcc,t)
        |h::t when h % 2<>0 -> innerHelp(aEvenAcc,h::aOddAcc,t)
        |[] -> (List.rev aEvenAcc,List.rev aOddAcc)
        |_-> innerHelp(aEvenAcc,aOddAcc,aList1)
      in innerHelp([],[],aList1)
    
    let rec dlugoscMWithoutTail aList1 =
      match aList1 with 
      |h::t -> 1 + dlugoscMWithoutTail t
      |[] -> 0
    
        
    //    let isPalindromeM aList1= List.rev aList1 = aList1
    //    let rec polaczM aList1 aList2 =
    //      let _switch =
    //        match _switch with
    //        |true ->  
    //
    //
    //        |(h1::t1,0,h2::t2) -> h1::innerHelp(t1,1,aList2)
    //        |(h1::t1,1,h2::t2) -> h2::innerHelp(aList2,0,t2)
    //        |([],_,[])-> []
    //        |(_,1,[])->
    ////      let rec areAllLowerThan(aList1, aVal) = 
    //        if aList1 = [] then true
    //        else if ( ( List.head aList1 ) < aVal ) then true && areAllLowerThan(List.tail aList1, aVal)
    //        else false
    
    //    let rec length aList1= 
    //      if aList1= [] then 0
    //      else 1 + length (List.tail aList1)
    //
    //    let rec dlugosc aLista = 
    //      let rec dlugoscTailed (aLista,acc) = 
    //        if aLista = [] then acc
    //        else dlugoscTailed (List.tail aLista,acc+1)
    //      in dlugoscTailed (aLista,0)
    //
    //
    //
    let rec polaczNotTailed aLista1 aLista2 = 
      match (aLista1,aLista2) with 
          | (h1::t1,h2::t2) -> h1::h2::polaczNotTailed (List.tail aLista1) (List.tail aLista2)
          | ([],h2::t2) -> h2::polaczNotTailed ([]) (List.tail aLista2) 
          | (h1::t1,[]) -> h1::polaczNotTailed (List.tail aLista1) ([]) 
          | _ -> []
    //
    ////    let succ_tail n =
    ////      let rec succ_iter(n,acc) = 
    ////        if n = 0 then acc else succ_iter(n-1,acc+1)
    ////      in succ_iter(n,1)
    //
    //
    //
    //
    //    let rec sqr aList1= 
    //      if aList1=[] then []
    //      else ( List.head aList1* List.head aList1)::sqr(List.tail aList1)
    //
    //    let rec appendLists (aList1, aList2) = 
    //      if aList1=[] then aList2  
    //      else List.head aList1 :: appendLists(List.tail aList1, aList2)
    //
    //    let rec count (aObject,aList1) = 
    //      if aList1=[] then 0
    //      else if List.head aList1= aObject then 1+count(aObject,List.tail aList1)
    //      else count(aObject,List.tail aList1)
    //
    //    let rec sum aList = 
    //      if aList = [] then 0.
    //      else List.head aList + sum (List.tail aList)
    //
    //    let rec enqueue (aList1, aElement) = 
    //      if aList1=[] then aElement  
    //      else List.head aList1 :: appendLists(List.tail aList1, aElement)
    //
    //    let rec generateAllInclusive (aLowerScope,aHigherScope) =
    //      if aLowerScope = aHigherScope then aLowerScope::[]
    //      else aLowerScope :: generateAllInclusive (aLowerScope+1,aHigherScope)
    //
    //    let rec toString (aList1,aSeparator) = 
    //      if List.tail aList1 = [] then List.head aList1^""
    //      else List.head aList1 ^ aSeparator ^ toString(List.tail aList1,aSeparator)
    //
    ////    let rec podziel aLista =
    ////        match aLista with 
    ////        | h  2 = 0    -> podziel (h::[],[])
    ////        | h / 2 <> 0   -> podziel (h::[],[])
    ////        | - -> podziel([],[])
    //
    //
    ////    let rec podziel aLista =
    ////        match aLista with 
    ////        | []  -> ([],[])
    ////        | x::xs ->
    ////          if x % 2 = 0 then (x::[],[2])
    ////          else if x % 2 <> 0 then ([],x::[])
    ////          else ([],[])
    //
    let toTwoTuple aList1 = 
      match aList1 with 
        | [] -> ([],[])
        | h::tail -> ([h],tail)
    //
    //    let pullSeg aList1= ([List.head aList1],List.tail aList1)
    //
    //    let pullAllListsIntoTuple aList1= (aList1,aList1)
    //
    //    let changeOnlyOneListInTuple aList1 = pullAllListsIntoTuple(aList1)
    //      
    //    let rec filter aList1 aDivider = 
    //      if aList1=[] then []
    //      else if BT.Predicate.modularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filter ( List.tail aList1 ) aDivider
    //      else filter ( List.tail aList1 ) aDivider
    //
    //    let rec filterWithOwnPredicate aList1 aDivider = 
    //      if aList1=[] then []
    //      else if BT.Predicate.modularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filter ( List.tail aList1 ) aDivider
    //      else filter ( List.tail aList1 ) aDivider
    //
    //    let rec filterWithTruePred aList1 aDivider = 
    //      if aList1=[] then []
    //      else if BT.Predicate.modularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filterWithTruePred ( List.tail aList1 ) aDivider
    //      else filter ( List.tail aList1 ) aDivider
    //
    //    let rec filterWithFalsePred aList1 aDivider = 
    //      if aList1=[] then []
    //      else if BT.Predicate.notModularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filterWithFalsePred ( List.tail aList1 ) aDivider
    //      else filterWithFalsePred ( List.tail aList1 ) aDivider
    //
    ////        let rec count (aObject,aList1) = 
    ////      if aList1=[] then 0
    ////      else if List.head aList1= aObject then 1+count(aObject,List.tail aList1)
    ////      else count(aObject,List.tail aList1)
    //
    //    let rec equalityList aList1 = 
    //      let pullSeg = (List.head aList1,List.tail aList1)
    //      if aList1 = [] then []
    //      else ( List.head aList1 ) :: equalityList ( List.tail aList1 )
    //
    //    let rec podzielPolymorphic aLista aFirstDivider aSecondDivider= 
    //      (filterWithTruePred aLista aFirstDivider,filterWithTruePred aLista aSecondDivider)
    //
    //    let rec podzielConcrete aLista = 
    //      (filterWithTruePred aLista 2,filterWithFalsePred aLista 2)
    //
    //
    //module List_Checkers =
    //      let rec areAllLowerThan(aList1, aVal) = 
    //        if aList1 = [] then true
    //        else if ( ( List.head aList1 ) < aVal ) then true && areAllLowerThan(List.tail aList1, aVal)
    //        else false
            