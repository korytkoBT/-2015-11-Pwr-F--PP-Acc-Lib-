namespace BT.Matcher.Test
    module List =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open BT.Matcher.List
    open BT.Matcher.Predicate
    
    //open BT.List_CheckersMatchers
    //open BT.PredicateMatchers
    
    [<Test>]
    let BT_ListPalindromeWithRev() =
      let _inputVal1 = [3;2;3]
    
      let _expectedVal = true
      let _reachedVal = isPalindromeM _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListCounterMatcher() =
      let _inputVal1 = 1
      let _inputVal2 = [1;2;1]
      
      let _expectedVal = 2
      let _reachedVal = countM ( _inputVal1,_inputVal2)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListLength() =
      let _inputVal1 = [1;2;3;4]
    
      let _expectedVal = 4
      let _reachedVal = lengthM _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)
       
    [<Test>]
    let BT_ListSquare() =
      let _inputVal1 = [1;2;3;-4]
    
      let _expectedVal = [1;4;9;16]
      let _reachedVal = sqrM _inputVal1
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListAppendListsMatcher() =
      let _inputVal1 = [1;2;3]
      let _inputVal2 = [3;2;1]
    
      let _expectedVal = [1;2;3;3;2;1]
      let _reachedVal = appendM _inputVal1 _inputVal2
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListSummer() =
      let _inputVal1 = [5.;3.;2.]
      
      let _expectedVal = 10.
      let _reachedVal = sumM _inputVal1
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListOfStringsJoiner() =
      let _inputVal1 = ["To"; "jest"; "napis"]
      let _inputVal2 = "-"
      
      let _expectedVal = "To-jest-napis"
      let _reachedVal = toStringM _inputVal1 _inputVal2
        
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListValuesLowerThanProper() =
      let _inputVal1 = [1;2;3;4]
      let _inputVal2 = 5
      
      let _expectedVal = true
      let _reachedVal = mniejszeM _inputVal1 _inputVal2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListValuesLowerThanFalse() =
      let _inputVal1 = [6;1;3;2]
      let _inputVal2 = 6
    
      let _expectedVal = false
      let _reachedVal = mniejszeM _inputVal1 _inputVal2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListFactoryBetweenScopes() =
      let _inputVal1 = 4
      let _inputVal2 = 8
      
      let _expectedVal = [4;5;6;7;8]
      let _reachedVal = genListM _inputVal1 _inputVal2
    
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListValuesLowerComparatorTrue() =
      let _inputVal1 = [1;2;3;4]
      let _inputVal2 = 5
      
      let _expectedVal = true
      let _reachedVal = mniejszeM2 _inputVal1 _inputVal2
    
      
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListValuesLowerComparatorFalse() =
      let _inputVal1 = [6;1;3;2]
      let _inputVal2 = 6
      
      let _expectedVal = false
      let _reachedVal = mniejszeM2 _inputVal1 _inputVal2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListFilterByEven() =
      let _inputVal1 = [3;6;8;9;13]
      
      let _expectedVal = ([6;8],[3;9;13])
      let _reachedVal = podzielM _inputVal1
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let BT_ListLengthMIMeanThatWithoutTail() =
      let _inputVal1 = [5;4;3;2]
      
      let _expectedVal = 4
      let _reachedVal = dlugoscMWithoutTail _inputVal1
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    //[<Test>]
    //let BT_ListAppendTailRec() =
    //  let _inputVal1 = [5;4;3;2]
    //  let _inputVal2 = [1;2;3;4;5;6]
    //
    //  let _expectedVal = [5;1;4;2;3;3;2;4;5;6]
    //  let _reachedVal = polaczM _inputVal1 _inputVal2
    //
    //  printf "OutputList :%A !!!!!!!!!!!!!!!!!!!" _reachedVal
    
    [<Test>]
    let BT_ListSwitcherUnitSettedFalse() =
      let _inputVal1 = [5;4;3;2]
      let _inputVal2 = [1;2;3;4;5;6]
      let _initLogic = false
    
      let _expectedVal = [5]
      let _reachedVal = switch _inputVal1 _inputVal2 _initLogic
       
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListSwitcherUnitSettedTrue() =
      let _inputVal1 = [5;4;3;2]
      let _inputVal2 = [1;2;3;4;5;6]
      let _initLogic = true
    
      let _expectedVal = [1]
      let _reachedVal = switch _inputVal1 _inputVal2 _initLogic
    
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListSwitcherUnitSettedFalseButIsEmpty() =
      let _inputVal1 = []
      let _inputVal2 = [1;2;3;4;5;6]
      let _initLogic = false
    
      let _expectedVal = [1]
      let _reachedVal = switch _inputVal1 _inputVal2 _initLogic
    
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListSwitcherUnitSettedTrueButIsEmpty() =
      let _inputVal1 = [5;4;3;2]
      let _inputVal2 = []
      let _initLogic = true
    
      let _expectedVal = [5]
      let _reachedVal = switch _inputVal1 _inputVal2 _initLogic
    
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    
    //
    [<Test>]
    let BT_ListAppendTailRec() =
      let _inputVal1 = [5;4;3;2]
      let _inputVal2 = [1;2;3;4;5;6]
    
      let _expectedVal = [5;1;4;2;3;3;2;4;5;6]
      let _reachedVal = polaczNotTailed _inputVal1 _inputVal2
    
      _reachedVal |> List.iter (fun x -> printf "%d " x)
    
      Assert.AreEqual(_expectedVal,_reachedVal)
    //
    //
    //[<Test>]
    //let BT_ListEnqueue() =
    //  let _inputVal1 = [1;2;3]
    //  let _inputVal2 = [4]
    //
    //  let _expectedVal = [1;2;3;4]
    //  let _reachedVal = enqueue (_inputVal1,_inputVal2)
    //
    //  Assert.AreEqual(_expectedVal,_reachedVal)
    
    [<Test>]
    let BT_ListSummerMatcher() =
      let _inputVal1 = [5.;3.;2.] 
      
      let _expectedVal = 10.
      let _reachedVal = sumM _inputVal1
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    