namespace BT.Matcher.Test
    module Element=

    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.Matcher.Element
    
    [<Test>]
    let BT_ElementDuplicateMatcher() =
      let _inputVal1 = "3"
      let _inputMultiplicant = 3
    
      let _reachedValue = duplicateM ( _inputVal1,_inputMultiplicant )
    
      let _expectedVal = ["3";"3";"3"]
      let _reachedComparison = _expectedVal = _reachedValue 
    
      Assert.True(_reachedComparison)
    
    

    
    
    
    

    
    
    
    

    
    
    
    

    
    

    