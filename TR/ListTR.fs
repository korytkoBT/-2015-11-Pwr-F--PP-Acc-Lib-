namespace BT.RecTail
    module List =
    open BT.RecTail.Predicate

    let rec engine aList = 
      let rec help (aListHelp,aAcc)=
        match aListHelp with
        |h::t -> help (t,h::aAcc)
        |[] -> aAcc
      in help(aList,[])

        
    let odwroc aList1 = engine aList1

    let rec appendM aList1 aList2 = // !!!!!!!!!!!!!!!!!!!!! TODO
      match aList1 with
      |[] -> aList2
      |mHead::mTail -> mHead::appendM mTail aList2

    let rec natrzy aList1 =
      let rec help(accMod10,accMod5,accModRest,aTape)=
        match aTape with
          |h::t when h%10 = 0 -> help(h::accMod10,accMod5,accModRest,t)
          |h::t when h%5 = 0 -> help(accMod10,h::accMod5,accModRest,t)
          |h::t -> help(accMod10,accMod5,h::accModRest,t)
          |[] -> (engine accMod10,engine (appendM accMod5 accMod10) ,engine accModRest)
      in help([],[],[],aList1)

    let rec countTR (aInEl1,aInList1 ) = 
      let rec helpCount (aInElHelp1,aInHelpList1,aAcc) =
        match aInHelpList1 with
        |h::t when h=aInElHelp1-> helpCount(aInElHelp1,t,1+aAcc)
        |h::t when h<>aInElHelp1-> helpCount(aInElHelp1,t,aAcc)
        |[] -> aAcc
        |_ -> 0
      in helpCount(aInEl1,aInList1,0)

    let rec duplicateTR (aInVal1,aInMulti) = 
      let rec helpDupl(helpVal1,helpMulti,Acc) =
        match helpMulti with
        |0 -> Acc
        |_ -> helpDupl(helpVal1,helpMulti-1,helpVal1::Acc)
      in helpDupl(aInVal1,aInMulti,[])

    let rec podziel aLista aElement =
      let rec help(higherAcc,lowerAcc,aTape) =
        match aTape with
        |h::t when h=aElement -> help(higherAcc,lowerAcc,t)
        |h::t when h>aElement -> help(h::higherAcc,lowerAcc,t)
        |h::t when h<aElement -> help(higherAcc,h::lowerAcc,t)
        |[] -> (engine higherAcc,engine lowerAcc)
        |_ -> ([],[])
      in help([],[],aLista)

      
    let rec sqrTR aList = 
      let rec help (aListHelp,aAcc)=
        match aListHelp with
        |h::t -> help (t,(h*h)::aAcc)
        |[] -> List.rev aAcc
      in help(aList,[])

    let rec isPalindromeTR aList=
      let rec help(aListHelp,aListPrevious,aCC)=
        match aListHelp with
       |h::t -> help(t,aListPrevious,h::aCC)
       |[] -> aCC=aListPrevious
      in help(aList,aList,[])

    let rec listLengthTR aList=
      let rec help(aListHelp,aCC)=
        match aListHelp with
        |h::t->help(t,aCC+1)
        |[]->aCC
      in help(aList,0)
    
//    let rec appendListsTR aInList1 aInList2 =
//      let rec helper(helpList1,helpList2,aFlag) =
//        match aFlag with
//        |true -> switch ( helpList1 helpList2 true ) :: helper(helpList1,List.rev helpList2,false)
//        |false -> switch ( helpList1 helpList2 false ) :: helper(List.rev helpList1,helpList2,true)
//      in helper(aInList1,aInList2,false)

//    let rec polaczTR aList0 aList1 = 
//      let h0 ( aList0,aList1 ) = switch aList0 aList1 0
//      let h1 ( aList0,aList1 ) = switch aList0 aList1 1
//      let rec helpPolacz (hList0,hList1,hAcc,hFlag) =
//        match (hList0,hList1) with
//        |([],[]) -> hAcc
//        |_ -> 
//          match hFlag with
//          |false -> helpPolacz(List.tail hList0,hList1,h0::hAcc,true)
//          |true -> helpPolacz(hList0,List.tail hList1,h1::hAcc,false)
//        hAcc
//      in helpPolacz(aList0,aList1,[],false)

    let rec polaczFromEndTR aList0 aList1 = 
      let rec helpPolacz (hList0,hList1,hAcc,hFlag) =
        match (hList0,hList1) with
        |([],[]) -> hAcc
        |_ -> 
          match hFlag with
          |false -> helpPolacz(List.tail hList0,hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
          |true -> helpPolacz(hList0,List.tail hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
        in helpPolacz(aList0,aList1,[],false)

    let rec polaczTR aList0 aList1 = 
      let rec helpPolacz (hList0,hList1,hAcc,hFlag) =
        match (hList0,hList1) with
        |([],[]) -> hAcc
        |_ -> 
          match hFlag with
          |false -> helpPolacz(List.tail hList0,hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
          |true -> helpPolacz(hList0,List.tail hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
        in helpPolacz(engine aList0,engine aList1,[],true)

    let rec polacz aList0 aList1 = 
      let rec helpPolacz (hList0,hList1,hAcc,hFlag) =
        match (hList0,hList1) with
          |([],[]) -> hAcc
          |([],_) -> helpPolacz(hList0,List.tail hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
          |(_,[]) -> helpPolacz(List.tail hList0,hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
          |_ -> ([])
        in helpPolacz(engine aList0,engine aList1,[],true)
        // why it takes from second one
        // switch only when all aren't empty , either append rest Of List
//
//                |_ -> 
//          match hFlag with
//          |false -> helpPolacz(List.tail hList0,hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
//          |true -> helpPolacz(hList0,List.tail hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
//        in helpPolacz(engine aList0,engine aList1,[],true)
          
    
//  let rec duplicate (aToReply,aCounter) = 
//   if aCounter=0 then []
//   else aToReply::duplicate(aToReply,aCounter-1)

    let rec polaczSwitch aList0 aList1 = 
      let rec helpPolacz (hList0,hList1,hAcc,hFlag) =
        match (hList0,hList1) with
          |([],[]) -> hAcc
          |([],_) -> helpPolacz(hList0,List.tail hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
          |(_,[]) -> helpPolacz(List.tail hList0,hList1,(switch hList0 hList1 hFlag):: hAcc,not hFlag)
          |_ -> ([])
        in helpPolacz(engine aList0,engine aList1,[],true)

//    let rec appendRecTail aListOfList = 
//      let rec help(aListOfList,acc) =
//        match aListOfList with
//        |[h,t] when h = [] ->
//          |_ -> help(t,appendM h acc)
//        |[] -> acc
//        |_ -> []
//      in help(aListOfList,[])

    let abs aVal =
      if aVal < 0 then -aVal
      else aVal

    let rec power aBase aPower =
      let rec help(aPower,acc) =
        if aPower>0 then help(aPower-1,aBase*acc)
        else if aPower=0 then help(aPower-1,acc)
        else acc
      in help(aPower,1);

    let rec contains aList aEl =
      if countTR(aEl,aList) > 0 then true
      else false
//        let rec countTR (aInEl1,aInList1 ) = 
//      let rec helpCount (aInElHelp1,aInHelpList1,aAcc) =
//        match aInHelpList1 with
//        |h::t when h=aInElHelp1-> helpCount(aInElHelp1,t,1+aAcc)
//        |h::t when h<>aInElHelp1-> helpCount(aInElHelp1,t,aAcc)
//        |[] -> aAcc
//        |_ -> 0
//      in helpCount(aInEl1,aInList1,0)

    let total aVal= aVal/16
    let modulo aVal = aVal%16
    let xor aVal1 aVal2 = 
      if aVal1 = 1 && aVal2 = 0 then true
      else if aVal1 = 0 && aVal2 = 1 then true
      else false


    let rec binToHexa aInputVal1 = 
      let rec help (aInVal , acc) =
        match aInVal with
        |aInVal when aInVal = 0 && total aInVal > 0 -> List.rev acc
        |aInVal when aInVal = 0 ^^ modulo aInVal = 0 -> [0]
        |aInVal when aInVal = 0 -> List.rev acc
        |aInVal when total aInVal > 0 -> help(modulo aInVal,(total aInVal)::acc)        
        |aInVal when total aInVal = 0 -> List.rev (aInVal % 16 :: acc)
        |_ -> []

      in help(aInputVal1,[])

//          let rec binToHexa aInputVal1 =
//      let rec help (aInVal , acc, aTotal) =
//        match aInVal with
//        |aInVal when total aInVal > 0 -> help(modulo aInVal,(total aInVal)::acc,total (modulo aInVal))
//        |aInVal when aInVal = 0 && aTotal > 0 -> List.rev acc
////        |aInVal when aInVal = 0 -> List.rev acc
//        |aInVal when total aInVal = 0 -> List.rev (aInVal % 16 :: acc)
//        |_ -> []
//
//      in help(aInputVal1,[],total aInputVal1)

    let rec sum2 (aList: int list) = 
      let rec sumHelp (aList,acc) =
        if aList = [] then acc
        else sumHelp(List.tail aList,List.head aList)
      in sumHelp(aList,0)

    let rec filterLL aListOfList aElement =
      let rec help(aListOfList,acc) = 
        match aListOfList with
        |h::t->
          if (sum2 h =aElement) then help(t,h::acc)
          else help(t,acc)
        |[] -> List.rev acc
      in help(aListOfList,[])

    

//              |h::t when contains h aElement-> help(t,aElement,h@acc)
//        |h::t -> help(t,aElement,acc)
      

//          let rec binToHexa aInputVal1 =
//      let rec help (aInVal , acc, aTotal) =
//        match aInVal with
//        |aInVal when aTotal > 0 -> help(aInVal-16,(aInVal/16)::acc,total (aInVal-16))
//        |aInVal when aInVal = 0 -> List.rev acc
//        |aInVal when aTotal = 0 -> help(0,aInVal::acc,total (aInVal-16))
//        |_ -> []
//
//      in help(aInputVal1,[],total aInputVal1)
      

//    31/16
      



        

