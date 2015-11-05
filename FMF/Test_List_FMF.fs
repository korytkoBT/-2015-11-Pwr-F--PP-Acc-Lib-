namespace BT.FMF.Test
    module List =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.FMF.List
    
    [<Test>]
    let BT_List_Fold_Right() =
      let _inputVal1 = [5.;3.;2.]
      
      let _expectedVal = 10.
      let _reachedVal = fold_right (+) _inputVal1 0.0
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_List_Count_FMFRight() =
      let _inputVal1 = 1
      let _inputVal2 = [1;2;1]
      
      let _expectedVal = 2
      let _reachedVal = countFMFRight ( _inputVal1,_inputVal2 )
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_List_Count_FMFLeft() =
      let _inputVal1 = 1
      let _inputVal2 = [1;2;1]
      
      let _expectedVal = 2
      let _reachedVal = countFMFLeft ( _inputVal1,_inputVal2 )
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListSquare() =
      let _inputVal1 = [1;2;3;-4]
    
      let _expectedVal = [1;4;9;16]
      let _reachedVal = sqrFMF _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListPalindromeWithRev() =
      let _inputVal1 = [3;2;3]
    
      let _expectedVal = false
      let _reachedVal = isPalindromeFMF _inputVal1

      printf "!!!!!!!!!!!!!!!!!!!!!!!!MUST_DO!!!!!!!!!!!!!!!!!!1"
    
      Assert.AreEqual(_expectedVal,_reachedVal)  