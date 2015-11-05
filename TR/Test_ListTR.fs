namespace BT.RecTail.Test
    module List =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.RecTail.List
    
    [<Test>]
    let BT_Lab2_13_Odwroc1 =
      let _inputVal1 = []
    
      let _expectedVal = []
      let _reachedVal = odwroc _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_Lab2_13_Odwroc2 =
      let _inputVal1 = [3;2;3]
    
      let _expectedVal = [3;2;3]
      let _reachedVal = odwroc _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_Lab2_13_Odwroc3 =
      let _inputVal1 = [1;2;3]
    
      let _expectedVal = [3;2;1]
      let _reachedVal = odwroc _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    
    [<Test>]
    let BT_Lab2_13_Natrzy1 =
      let _inputVal1 = [3;5;6;10;15;20;25;30;40]
    
      let _expectedVal = ([10;20;30;40],[5;15;10;20;30;40],[3;6])
      let _reachedVal = natrzy _inputVal1

      let (x1,x2,x3) = ([10;20;30;40],[5;15;10;20;30;40],[3;6])
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_Lab2_13_Natrzy2 =
      let _inputVal1 = [20;21;25;30;40]
    
      let _expectedVal = ([20;30;40],[20;25;30;40],[21])
      let _reachedVal = natrzy _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_Lab2_13_Natrzy3 =
      let _inputVal1 = [0;1;2;3]
    
      let _expectedVal = ([],[],[0;1;2;3])
      let _reachedVal = natrzy _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_Podziel() =
      let _inTape = [5;4;3;2;1]
      let _el = 3

      let _expectedVal = ([5;4],[2;1])
      let _reachedVal = podziel _inTape _el
    
      Assert.AreEqual(_expectedVal,_reachedVal) 
    [<Test>]
    let BT_ListCounter() =
      let _inputElement1 = 'a'
      let _inputList1 = ['a';'l';'a']
      
      let _expectedVal = 2
      let _reachedVal = countTR (_inputElement1,_inputList1 )
      
      let _reachedLogic = _expectedVal = _reachedVal
      
      Assert.True(_reachedLogic)

    [<Test>]
    let BT_ElementDuplicate() =
      let _inputVal1 = "3"
      let _inputMultiplicant = 3

      let _expectedVal = ["3";"3";"3"]

      let _reachedValue = duplicateTR ( _inputVal1,_inputMultiplicant )

      Assert.AreEqual(_expectedVal,_reachedValue)
        
    [<Test>]
    let BT_ListSquare() =
      let _inputVal1 = [1;2;3;-4]

      let _expectedVal = [1;4;9;16]
      let _reachedVal = sqrTR _inputVal1

      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_ListPalindromeWithRev() =
      let _inputVal1 = [3;2;3]
    
      let _expectedVal = true
      let _reachedVal = isPalindromeTR _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)

    [<Test>]
    let BT_ListLengthRec() =
      let _inputVal1 = [5;4;3;2]

      let _expectedVal = 4
      let _reachedVal = listLengthTR _inputVal1

      Assert.AreEqual(_expectedVal,_reachedVal)
      
 //  [<Test>]
 //   let BT_ListAppendInterweavedFinal() =
 //     let _inputVal1 = [5;4;3;2]
 //     let _inputVal2 = [1;2;3;4;5;6]
 //
 //     let _expectedVal = [5;1;4;2;3;3;2;4;5;6]
 //     let _reachedVal = polaczTR _inputVal1 _inputVal2
 //
 //     Assert.AreEqual(_expectedVal,_reachedVal)
//    
//    [<Test>]
//    let BT_ListAppendInterweavedPartial() =
//      let _inputVal1 = [5;4;3;2]
//      let _inputVal2 = [1;2;3;4]
//
//      let _expectedVal = [5;1;4;2;3;3;2;4]
//      let _reachedVal = polaczTR _inputVal1 _inputVal2
//
//      Assert.AreEqual(_expectedVal,_reachedVal)
//
//    [<Test>]
//    let BT_ListAppendInterweaveFromEnd() =
//      let _inputVal1 = [1;2;3;4;5]
//      let _inputVal2 = [6;7;8;9;10]
//
//      let _expectedVal = [10; 5; 9; 4; 8; 3; 7; 2; 6; 1]
//      let _reachedVal = polaczFromEndTR _inputVal1 _inputVal2
//
//      Assert.AreEqual(_expectedVal,_reachedVal)

//    [<Test>]
//    let BT_ListAppendInterweaveFromEnd() =
//      let _inputVal1 = [1;2;3;4;5]
//      let _inputVal2 = [6;7;8;9;10]
//
//      let _expectedVal = [1;2;3;4;5;6;7;8;9;10]
//      let _reachedVal = appendRecTail [_inputVal1,_inputVal2]
//
//      Assert.AreEqual(_expectedVal,_reachedVal)

//    [<Test>]
//    let BT_ListPolacz() =
//      let _inputVal1 = [5;4;3;2]
//      let _inputVal2 = [1;0] 
//
//      let _expectedVal = [5;4;3;2;1;0]
//      let _reachedVal = polacz _inputVal1 _inputVal2
//
//      printf "___________________________________REACHED POLACZ %A: " _reachedVal
//
//      Assert.AreEqual(_expectedVal,_reachedVal)
//
//    [<Test>]
//    let BT_ListPolaczTR() =
//      let _inputVal1 = [5;4;3;2]
//      let _inputVal2 = [1;0] 
//
//      let _expectedVal = [5;4;3;2;1;0]
//      let _reachedVal = polaczTR _inputVal1 _inputVal2
//
//      printf "___________________________________REACHED POLACZ %A: " _reachedVal
//
//      Assert.AreEqual(_expectedVal,_reachedVal)


//
//    [<Test>]
//    let BT_ListPolaczRecollecting() =
//      let _inputVal1 = [1;2;3;4;5]
//      let _inputVal2 = [6;7;8;9;10;11] 
//
//      let _expectedVal = [1;2;3;4;5;6;7;8;9;10;11]
//      let _reachedVal = polacz _inputVal1 _inputVal2
//
//      Assert.AreEqual(_expectedVal,_reachedVal)
//      let rec polaczLab aList0 aList1 = 

//// ======== Lists 1.1 ============
//[<Test>]
//let BT_ListPalindromeWithRev() =
//  let _inputVal1 = [3;2;3]
//
//  let _expectedVal = true
//  let _reachedVal = isPalindrome _inputVal1
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//[<Test>]
//let BT_ListLength() =
//  let _inputVal1 = [1;2;3]
//
//  let _expectedVal = 3
//  let _reachedVal = length _inputVal1
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//[<Test>]
//let BT_ListLengthRec() =
//  let _inputVal1 = [5;4;3;2]
//
//  let _expectedVal = 4
//  let _reachedVal = dlugosc _inputVal1
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//   
//[<Test>]
//let BT_ListSquare() =
//  let _inputVal1 = [1;2;3;-4]
//
//  let _expectedVal = [1;4;9;16]
//  let _reachedVal = sqr _inputVal1
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//[<Test>]
//let BT_ListAppendToList() =
//  let _inputVal1 = [1;2;3]
//  let _inputVal2 = [3;2;1]
//
//  let _expectedVal = [1;2;3;3;2;1]
//  let _reachedVal = appendLists(_inputVal1,_inputVal2)
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//
//[<Test>]
//let BT_ListEnqueue() =
//  let _inputVal1 = [1;2;3]
//  let _inputVal2 = [4]
//
//  let _expectedVal = [1;2;3;4]
//  let _reachedVal = enqueue (_inputVal1,_inputVal2)
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//

//
//[<Test>]
//let BT_ListSummer() =
//  let _inputVal1 = [5.;3.;2.]
//  
//  let _expectedVal = 10.
//  let _reachedVal = sum _inputVal1
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.True(_reachedLogic)
//
//[<Test>]
//let BT_ListValuesLowerComparator() =
//  let _inputVal1 = [1;2;3;4]
//  let _inputVal2 = 5
//  
//  let _expectedVal = true
//  let _reachedVal = areAllLowerThan ( _inputVal1,_inputVal2 )
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.True(_reachedLogic)
//
//[<Test>]
//let BT_ListFactoryBetweenScopes() =
//  let _inputVal1 = 4
//  let _inputVal2 = 8
//  
//  let _expectedVal = [4;5;6;7;8]
//  let _reachedVal = generateAllInclusive ( _inputVal1,_inputVal2 )
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.True(_reachedLogic)
//
//[<Test>]
//let BT_ListOfStringsJoiner() =
//  let _inputVal1 = ["To"; "jest"; "napis"]
//  let _inputVal2 = "-"
//  
//  let _expectedVal = "To-jest-napis"
//  let _reachedVal = toString ( _inputVal1,_inputVal2 )
//
//  printfn "%s" _expectedVal
//  printfn "%s" _reachedVal
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.True(_reachedLogic)
//
//
//[<Test>]
//let BT_ListFilteringOnlyMod2() =
//  let _inputVal1 = [3;6;8;9;13]
//  
//  let _expectedVal = [6;8]
//  let _reachedVal = filterWithTruePred _inputVal1 2
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//[<Test>]
//let BT_ListFilteringWithLamdaPredicate() =
//  let _inputVal1 = [3;6;8;9;13]
//  
//  let _expectedVal = [6;8]
//  let _reachedVal = filterWithTruePred _inputVal1 2
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//[<Test>]
//let BT_ListFilteringOnlyNotMod2() =
//  let _inputVal1 = [3;6;8;9;13]
//  
//  let _expectedVal = [3;9;13]
//  let _reachedVal = filterWithFalsePred _inputVal1 2
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
//[<Test>]
//let BT_ListFilteringReturningTupleWithNotMod() =
//  let _inputVal1 = [3;6;8;9;13]
//  
//  let _expectedVal = ( [6;8],[3;9;13] )
//  let _reachedVal = podzielConcrete _inputVal1
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.AreEqual(_expectedVal,_reachedVal)
//
////[<Test>]
////let BT_ListFilteringWithPredicate() =
////  let _inputVal1 = [2;1;2]
////  
////  let _expectedVal = ([2;2],[2;2])
////  let _reachedVal = podziel _inputVal1 2 2
////
////  let (_exp1,exp2) = _expectedVal
////
////  let _reachedLogic = _expectedVal = _reachedVal
////
////  Assert.AreEqual(_expectedVal,_reachedVal)
//
////[<Test>]
////let ListIntoTwoCopiesInInTwoTuple() =
////  let _inputVal1 = [1;2;1]
////  
////  let _expectedVal1 = [1;2;1]
////  let _reachedVal1 = equalityList _inputVal1
////
////  let _reachedLogic = _expectedVal1 = _reachedVal1
////
////  Assert.True(_reachedLogic)
//
//[<Test>]
//let ListIntoTwoSegmentsInTwoTupleWithOnlyValues() =
//  let _inputVal1 = [1;2;1]
//  
//  let _expectedVal1 = ([1],[2;1])
//  let _reachedVal1 = pullSeg _inputVal1
//
//  let _reachedLogic = _expectedVal1 = _reachedVal1
//
//  Assert.True(_reachedLogic)
//
//[<Test>]
//let ListIntoTwoCopiesInTwoTupleWithOnlyValues() =
//  let _inputVal1 = [1;2;1]
//  
//  let _expectedVal1 = ([1;2;1],[1;2;1])
//  let _reachedVal1 = pullAllListsIntoTuple _inputVal1
//
//  let _reachedLogic = _expectedVal1 = _reachedVal1
//
//  Assert.True(_reachedLogic)
//
//[<Test>]
//let ListFilterWithPredicateInArg() =
//  let _inputVal1 = [2;1;2]
//  let _divider = 2
//  
//  let _expectedVal = [2;2]
//  let _reachedVal = filter _inputVal1 _divider
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.True(_reachedLogic)
//
//
////
////[<Test>]
////let ListIntoTwoCopiesInInTwoTuple() =
////  let _inputVal1 = [1;2;1]
////  
////  let _expectedVal1 = ([1;2;1],[1;2;1])
////  let _reachedVal1 = toTwoCopiesInTwoTuple _inputVal1
////
////  let _reachedLogic = _expectedVal1 = _reachedVal1
////
////  Assert.True(_reachedLogic)
//


    [<Test>]
    let ValueAbsTest() =
      let _inputVal1 = -3
      
      let _expectedVal1 = 3
      let _reachedVal1 = abs _inputVal1
    
      let _reachedLogic = _expectedVal1 = _reachedVal1
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let ValueAbsTest2() =
      let _inputVal1 = 3
      
      let _expectedVal1 = 3
      let _reachedVal1 = abs _inputVal1
    
      let _reachedLogic = _expectedVal1 = _reachedVal1
    
      Assert.True(_reachedLogic)

    [<Test>]
    let PowerTest0() =
      let _inputVal1 = 2
      let _inputVal2 = 0
      
      let _expectedVal1 = 1
      let _reachedVal1 = power _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let PowerTest1() =
      let _inputVal1 = 2
      let _inputVal2 = 1
      
      let _expectedVal1 = 2
      let _reachedVal1 = power _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let PowerTest2() =
      let _inputVal1 = 2
      let _inputVal2 = 2
      
      let _expectedVal1 = 4
      let _reachedVal1 = power _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let PowerTest3() =
      let _inputVal1 = 2
      let _inputVal2 = 3
      
      let _expectedVal1 = 8
      let _reachedVal1 = power _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let ListCon1() =
      let _inputVal1 = [1;2;3]
      let _inputVal2 = 3
      
      let _expectedVal1 = true
      let _reachedVal1 = contains _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let ListCon2() =
      let _inputVal1 = [1;2;3]
      let _inputVal2 = 1
      
      let _expectedVal1 = true
      let _reachedVal1 = contains _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let ListCon3() =
      let _inputVal1 = [1;2;3]
      let _inputVal2 = 4
      
      let _expectedVal1 = false
      let _reachedVal1 = contains _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let Exercise21() =
      let _inputVal1 = 31
      
      let _expectedVal1 = [1;15]
      let _reachedVal1 = binToHexa _inputVal1

      printfn "Goal 31: %A" _reachedVal1
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)

    [<Test>]
    let Exercise22() =
      let _inputVal1 = 16
      
      let _expectedVal1 = [1]
      let _reachedVal1 = binToHexa _inputVal1

      printfn "Goal 16: %A" _reachedVal1
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)


    [<Test>]
    let Exercise23() =
      let _inputVal1 = 0
      
      let _expectedVal1 = [0]
      let _reachedVal1 = binToHexa _inputVal1

      printfn "Goal 0: %A" _reachedVal1
    
      Assert.AreEqual(_expectedVal1,_reachedVal1)
//
//    [<Test>]
//     let BT_FilterLists() =
//       let _inputVal1 = [[1;2;3];[2;4];[5;6]]
//       let _inputVal2 = 6
// 
//       let _expectedVal = [[1;2;3];[2;4]]
//       let _reachedVal = filterLL _inputVal1 _inputVal2

//       printfn "Goal: %A" _reachedVal
 
//       Assert.AreEqual(_expectedVal,_reachedVal)

//     [<Test>]
//     let BT_FilterLists2() =
//       let _inputVal1 = [[1;2;3];[2;4];[5;6]]
//       let _inputVal2 = 11
// 
//       let _expectedVal = [[5;6]]
//       let _reachedVal = filterLL _inputVal1 _inputVal2
//
//       printfn "Goal: %A" _reachedVal
// 
//       Assert.AreEqual(_expectedVal,_reachedVal)

//     [<Test>]
//     let BT_FilterLists3() =
//       let _inputVal1 = [[1;2;3];[2;4];[5;6]]
//       let _inputVal2 = 12
// 
//       let _expectedVal = []
//       let _reachedVal = filterLL _inputVal1 _inputVal2
//
//       printfn "Goal: %A" _reachedVal
// 
//       Assert.AreEqual(_expectedVal,_reachedVal)