namespace BT.Rec_Branch
  module Currying=

    let o f1 f2 = fun x -> f1 (f2 x)
    let o2 f1 f2 x = f1 (f2 x)

    let f1Add1 x = x+1

    let f2Triple x = 3*x

    let complex f1 f2 x = o f1 f2 x

    let cr f1 f2 = fun x -> f2 x f1

    