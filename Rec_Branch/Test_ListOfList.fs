namespace BT.Rec_Branch.Test
  module ListOfList =

open System
open System.Collections
open NUnit.Framework
open NUnit.Framework.Constraints
open BT.Rec_Branch.ListOfLists

[<Test>]
let TestOfFlattingList() =
  let _inputVal1 = [1;2;1]
  let _inputVal2 = [1;2;1]
    
  let _expectedVal = [1;2;1;1;2;1]
  let _reachedVal = flatten ( [_inputVal1;_inputVal2] )

  let _reachedLogic = _expectedVal = _reachedVal

  Assert.True(_reachedLogic)

