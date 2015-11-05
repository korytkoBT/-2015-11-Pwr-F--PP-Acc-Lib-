namespace BT.Rec_Branch
  module Predicate=

    let modularOf ( aValIn:int,aDivider ) = aValIn % aDivider = 0

    let notModularOf ( aValIn:int,aDivider ) = aValIn % aDivider <> 0

    let predicate1 = fun x-> x%2=0

    let predicate2 x = x%2=0

    let takeFromListOnlyPredicatHead aList = 
      if predicate1 ( List.head aList  ) then 0
      else 1
