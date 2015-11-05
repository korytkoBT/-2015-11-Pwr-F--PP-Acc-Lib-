namespace BT.Rec_Branch.Test
  module Element =

open System
open System.Collections
open NUnit.Framework
open NUnit.Framework.Constraints
open BT.Rec_Branch.Element

[<Test>]
let BT_ElementDuplicate() =
  let _inputVal1 = "3"
  let _inputMultiplicant = 3

  let _reachedValue = duplicate ( _inputVal1,_inputMultiplicant )

  let _expectedVal = ["3";"3";"3"]
  let _reachedComparison = _expectedVal = _reachedValue 

  Assert.True(_reachedComparison)

