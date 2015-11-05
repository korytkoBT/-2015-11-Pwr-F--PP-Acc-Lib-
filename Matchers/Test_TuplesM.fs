namespace BT.Matcher.Test
    module Tuples=
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.Matcher.Tuples
    
    //[<Test>]
    //let BT_TuplesGetThird() =
    //  let _inputVal1 = (6,4.,"ala")
    //  let _inputMultiplicant = 3
    //
    //  let _reachedValue = third _inputVal1
    //
    //  let _expectedVal = "ala"
    //  let _reachedComparison = _expectedVal = _reachedValue 
    //
    //  Assert.True(_reachedComparison)
    
    [<Test>]
    let BT_TuplesSumFourT() =
      let _inputVal1 = (3.,2.,5.,1.)
      let _expectedVal = 11.
    
      let _reachedValue = sumAllM _inputVal1
    
      let _reachedComparison = _expectedVal = _reachedValue 
    
      Assert.True(_reachedComparison)


