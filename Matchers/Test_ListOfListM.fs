﻿namespace BT.Matcher.Test
    module ListOfList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.Matcher.ListOfLists
    
    [<Test>]
    let TestOfFlattingListMatcher() =
      let _inputVal1 = [1;2;1]
      let _inputVal2 = [1;2;1]
      let _inputCummVal1 = [[1;2;1];[1;2;1]]
        
      let _expectedVal = [1;2;1;1;2;1]
      let _reachedVal = flattenM ( _inputCummVal1 )
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    