namespace BT.Rec_Branch.Test
  module List =

open System
open System.Collections
open NUnit.Framework
open NUnit.Framework.Constraints
open BT.Rec_Branch.List
open BT.Rec_Branch.Predicate

// ======== Lists 1.1 ============
[<Test>]
let BT_ListPalindromeWithRev() =
  let _inputVal1 = [3;2;3]

  let _expectedVal = true
  let _reachedVal = isPalindrome _inputVal1

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListPodzielOnHigherThan() =
  let _inputVal1 = [5;4;3;2;1]
  let _el = 3
   
  let _expectedVal = [5;4]
  let _reachedVal = podzielOnHigher _inputVal1 _el

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListPodzielOnLowerThan() =
  let _inputVal1 = [5;4;3;2;1]
  let _el = 3
   
  let _expectedVal = [2;1]
  let _reachedVal = podzielOnLower _inputVal1 _el

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
 let BT_ListPodziel() =
   let _inputVal1 = [5;4;3;2;1]
   let _el = 3
   
   let _expectedVal = ([5;4],[2;1])
   let _reachedVal = podziel _inputVal1 _el

   Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListLength() =
  let _inputVal1 = [1;2;3]

  let _expectedVal = 3
  let _reachedVal = length _inputVal1

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListLengthRec() =
  let _inputVal1 = [5;4;3;2]

  let _expectedVal = 4
  let _reachedVal = dlugosc _inputVal1

  Assert.AreEqual(_expectedVal,_reachedVal)
   
[<Test>]
let BT_ListSquare() =
  let _inputVal1 = [1;2;3;-4]

  let _expectedVal = [1;4;9;16]
  let _reachedVal = sqr _inputVal1

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListAppendToList() =
  let _inputVal1 = [1;2;3]
  let _inputVal2 = [3;2;1]

  let _expectedVal = [1;2;3;3;2;1]
  let _reachedVal = appendLists(_inputVal1,_inputVal2)

  Assert.AreEqual(_expectedVal,_reachedVal)


[<Test>]
let BT_ListEnqueue() =
  let _inputVal1 = [1;2;3]
  let _inputVal2 = [4]

  let _expectedVal = [1;2;3;4]
  let _reachedVal = enqueue (_inputVal1,_inputVal2)

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListCounter() =
  let _inputVal1 = 1
  let _inputVal2 = [1;2;1]
  
  let _expectedVal = 2
  let _reachedVal = count ( _inputVal1,_inputVal2 )

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)

[<Test>]
let BT_ListSummer() =
  let _inputVal1 = [5.;3.;2.]
  
  let _expectedVal = 10.
  let _reachedVal = sum _inputVal1

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)

[<Test>]
let BT_ListValuesLowerComparator() =
  let _inputVal1 = [1;2;3;4]
  let _inputVal2 = 5
  
  let _expectedVal = true
  let _reachedVal = areAllLowerThan ( _inputVal1,_inputVal2 )

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)

[<Test>]
let BT_ListFactoryBetweenScopes() =
  let _inputVal1 = 4
  let _inputVal2 = 8
  
  let _expectedVal = [4;5;6;7;8]
  let _reachedVal = generateAllInclusive ( _inputVal1,_inputVal2 )

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)

[<Test>]
let BT_ListOfStringsJoiner() =
  let _inputVal1 = ["To"; "jest"; "napis"]
  let _inputVal2 = "-"
  
  let _expectedVal = "To-jest-napis"
  let _reachedVal = toString ( _inputVal1,_inputVal2 )
  
  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)


[<Test>]
let BT_ListFilteringOnlyMod2() =
  let _inputVal1 = [3;6;8;9;13]
  
  let _expectedVal = [6;8]
  let _reachedVal = filterWithTruePred _inputVal1 2

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListFilteringWithLamdaPredicate() =
  let _inputVal1 = [3;6;8;9;13]
  
  let _expectedVal = [6;8]
  let _reachedVal = filterWithTruePred _inputVal1 2

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListFilteringOnlyNotMod2() =
  let _inputVal1 = [3;6;8;9;13]
  
  let _expectedVal = [3;9;13]
  let _reachedVal = filterWithFalsePred _inputVal1 2

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.AreEqual(_expectedVal,_reachedVal)

[<Test>]
let BT_ListFilteringReturningTupleWithNotMod() =
  let _inputVal1 = [3;6;8;9;13]
  
  let _expectedVal = ( [6;8],[3;9;13] )
  let _reachedVal = podzielConcrete _inputVal1

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.AreEqual(_expectedVal,_reachedVal)

//[<Test>]
//let BT_ListFilteringWithPredicate() =
//  let _inputVal1 = [2;1;2]
//  
//  let _expectedVal = ([2;2],[2;2])
//  let _reachedVal = podziel _inputVal1 2 2
//
//  let (_exp1,exp2) = _expectedVal
//
//  let _reachedLogic = _expectedVal = _reachedVal
//
//  Assert.AreEqual(_expectedVal,_reachedVal)

//[<Test>]
//let ListIntoTwoCopiesInInTwoTuple() =
//  let _inputVal1 = [1;2;1]
//  
//  let _expectedVal1 = [1;2;1]
//  let _reachedVal1 = equalityList _inputVal1
//
//  let _reachedLogic = _expectedVal1 = _reachedVal1
//
//  Assert.True(_reachedLogic)

[<Test>]
let ListIntoTwoSegmentsInTwoTupleWithOnlyValues() =
  let _inputVal1 = [1;2;1]
  
  let _expectedVal1 = ([1],[2;1])
  let _reachedVal1 = pullSeg _inputVal1

  let _reachedLogic = _expectedVal1 = _reachedVal1

  Assert.True(_reachedLogic)

[<Test>]
let ListIntoTwoCopiesInTwoTupleWithOnlyValues() =
  let _inputVal1 = [1;2;1]
  
  let _expectedVal1 = ([1;2;1],[1;2;1])
  let _reachedVal1 = pullAllListsIntoTuple _inputVal1

  let _reachedLogic = _expectedVal1 = _reachedVal1

  Assert.True(_reachedLogic)

[<Test>]
let ListFilterWithPredicateInArg() =
  let _inputVal1 = [2;1;2]
  let _divider = 2
  
  let _expectedVal = [2;2]
  let _reachedVal = filter _inputVal1 _divider

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)



//
//[<Test>]
//let ListIntoTwoCopiesInInTwoTuple() =
//  let _inputVal1 = [1;2;1]
//  
//  let _expectedVal1 = ([1;2;1],[1;2;1])
//  let _reachedVal1 = toTwoCopiesInTwoTuple _inputVal1
//
//  let _reachedLogic = _expectedVal1 = _reachedVal1
//
//  Assert.True(_reachedLogic)

