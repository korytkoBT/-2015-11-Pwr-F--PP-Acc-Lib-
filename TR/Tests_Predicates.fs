namespace BT.RecTail.Test
  module Predicates =

open System
open System.Collections
open NUnit.Framework
open NUnit.Framework.Constraints
open BT.RecTail.Predicate
open BT.RecTail.ListOfLists

//[<Test>]
//  let BT_SwitchFromFirstThread() =
//    let _inList1 = [1;2;3]
//    let _inList2 = [3;1;2]
//
//    let _reachedValue = switch _inList1 _inList2 false
//    let _expectedVal=1
//
//    let _reachedComparison = _expectedVal = _reachedValue 
//    
//    Assert.True(_reachedComparison)
//
//[<Test>]
//  let BT_SwitchFromSecondThread() =
//    let _inList1 = [1;2;3]
//    let _inList2 = [3;1;2]
//
//    let _reachedValue = switch _inList1 _inList2 true
//    let _expectedVal = 3
//
//    let _reachedComparison = _expectedVal = _reachedValue 
//    
//    Assert.True(_reachedComparison)
//
//  [<Test>]
//  let BT_SwitchSelectedSecondButEmpty() =
//    let _inList1 = [1;2;3]
//    let _inList2 = []
//
//    let _reachedValue = switch _inList1 _inList2 true
//    let _expectedVal = 1
//
//    let _reachedComparison = _expectedVal = _reachedValue 
//    
//    Assert.True(_reachedComparison)
//
//  [<Test>]
//  let BT_SwitchSelectedFirstButEmpty() =
//    let _inList1 = []
//    let _inList2 = [1;2;3]
//
//    let _reachedValue = switch _inList1 _inList2 false
//    let _expectedVal = 1
//
//    let _reachedComparison = _expectedVal = _reachedValue 
//    
//    Assert.True(_reachedComparison)

  [<Test>]
  let BT_SwitchSelectedTwoEmpty() =
    let _inList1 = []
    let _inList2 = []

    let _reachedValue = switch _inList1 _inList2 false
    let _expectedVal = []

    printfn "Reached Switch: %A" _reachedValue

    let _reachedComparison = _expectedVal = _reachedValue 
    
    Assert.True(_reachedComparison)
