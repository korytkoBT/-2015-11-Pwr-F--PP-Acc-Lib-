namespace BT.Rec_Branch.Test
    module Numeric=
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.Rec_Branch.Numeric
    
    [<Test>]
    let TestOfAddingValues() =
      let _inputVal1 = 0
      let _inputVal2 = 1
    
      let _expectedVal = 1
      let _reachedVal = add(_inputVal1,_inputVal2)
    
      Assert.AreEqual(_expectedVal,_reachedVal)
