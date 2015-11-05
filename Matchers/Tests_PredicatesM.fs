namespace BT.Matcher.Test
    module Predicates_FMF =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.Matcher.Predicate
    
    [<Test>]
      let BT_PredOfDividingBy2() =
        let _inputVal1 = 4
        let _expectedVal = true
    
        let _reachedValue = modularOf (_inputVal1,2)
    
        let _reachedComparison = _expectedVal = _reachedValue 
        
        Assert.True(_reachedComparison)
    
    [<Test>]
      let BT_PredOfNotDividingBy2() =
        let _inputVal1 = 5
        let _expectedVal = true
    
        let _reachedValue = notModularOf (_inputVal1,2)
    
        let _reachedComparison = _expectedVal = _reachedValue 
        
        Assert.True(_reachedComparison)
