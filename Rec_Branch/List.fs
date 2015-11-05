namespace BT.Rec_Branch
    module List =
    open BT.Rec_Branch.Predicate

    let isPalindrome aList1= List.rev aList1 = aList1

    let rec podzielOnHigher aLista aElement=
      match aLista with
      |h::t when h>aElement -> h::podzielOnHigher t aElement
      |h::t -> podzielOnHigher t aElement
      |[] -> []
      |_ -> []
      

    let rec podzielOnLower aLista aElement=
      match aLista with
      |h::t when h<aElement -> h::podzielOnLower t aElement
      |h::t -> podzielOnLower t aElement
      |[] -> []
      |_ -> []

    let podziel aLista aElement= 
      (podzielOnHigher aLista aElement,podzielOnLower aLista aElement)

//    let rec podziel aLista aElement =
//      let rec help(higherAcc,lowerAcc,aTape) =
//        match aTape with
//        |h::t when h=aElement -> help(higherAcc,lowerAcc,t)
//        |h::t when h>aElement -> help(h::higherAcc,lowerAcc,t)
//        |h::t when h<aElement -> help(higherAcc,h::lowerAcc,t)
//        |[] -> (engine higherAcc,engine lowerAcc)
//        |_ -> ([],[])
//      in help([],[],aLista)

    let rec length aList1= 
      if aList1= [] then 0
      else 1 + length (List.tail aList1)

    let rec dlugosc aLista = 
      let rec dlugoscTailed (aLista,acc) = 
        if aLista = [] then acc
        else dlugoscTailed (List.tail aLista,acc+1)
      in dlugoscTailed (aLista,0)

    let rec sqr aList1= 
      if aList1=[] then []
      else ( List.head aList1* List.head aList1)::sqr(List.tail aList1)

    let rec appendLists (aList1, aList2) = 
      if aList1=[] then aList2  
      else List.head aList1 :: appendLists(List.tail aList1, aList2)

    let rec count (aObject,aList1) = 
      if aList1=[] then 0
      else if List.head aList1= aObject then 1+count(aObject,List.tail aList1)
      else count(aObject,List.tail aList1)

    let rec sum aList = 
      if aList = [] then 0.
      else List.head aList + sum (List.tail aList)

    let rec sum2 (aList: int list) = 
      if aList = [] then 0
      else List.head aList + sum2 (List.tail aList)

    let rec enqueue (aList1, aElement) = 
      if aList1=[] then aElement  
      else List.head aList1 :: appendLists(List.tail aList1, aElement)

    let rec generateAllInclusive (aLowerScope,aHigherScope) =
      if aLowerScope = aHigherScope then aLowerScope::[]
      else aLowerScope :: generateAllInclusive (aLowerScope+1,aHigherScope)

    let rec toString (aList1,aSeparator) = 
      if List.tail aList1 = [] then List.head aList1^""
      else List.head aList1 ^ aSeparator ^ toString(List.tail aList1,aSeparator)

    let pullSeg aList1= ([List.head aList1],List.tail aList1)

    let pullAllListsIntoTuple aList1= (aList1,aList1)

    let changeOnlyOneListInTuple aList1 = pullAllListsIntoTuple(aList1)
      
    let rec filter aList1 aDivider = 
      if aList1=[] then []
      else if modularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filter ( List.tail aList1 ) aDivider
      else filter ( List.tail aList1 ) aDivider

    let rec filterWithOwnPredicate aList1 aDivider = 
      if aList1=[] then []
      else if modularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filter ( List.tail aList1 ) aDivider
      else filter ( List.tail aList1 ) aDivider

    let rec filterWithTruePred aList1 aDivider = 
      if aList1=[] then []
      else if modularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filterWithTruePred ( List.tail aList1 ) aDivider
      else filter ( List.tail aList1 ) aDivider

    let rec filterWithFalsePred aList1 aDivider = 
      if aList1=[] then []
      else if notModularOf(List.head aList1,aDivider) then ( List.head aList1 ) :: filterWithFalsePred ( List.tail aList1 ) aDivider
      else filterWithFalsePred ( List.tail aList1 ) aDivider

    let rec equalityList aList1 = 
      let pullSeg = (List.head aList1,List.tail aList1)
      if aList1 = [] then []
      else ( List.head aList1 ) :: equalityList ( List.tail aList1 )

    let rec podzielPolymorphic aLista aFirstDivider aSecondDivider= 
      (filterWithTruePred aLista aFirstDivider,filterWithTruePred aLista aSecondDivider)

    let rec podzielConcrete aLista = 
      (filterWithTruePred aLista 2,filterWithFalsePred aLista 2)

    let rec areAllLowerThan(aList1, aVal) = 
      if aList1 = [] then true
      else if ( ( List.head aList1 ) < aVal ) then true && areAllLowerThan(List.tail aList1, aVal)
      else false        