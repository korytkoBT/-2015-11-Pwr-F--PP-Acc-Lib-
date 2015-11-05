namespace BT.FMF
    module List =

    let rec map f l =     
      match l with         
      |[] -> []       
      |x::xs -> (f x) :: map f xs

    let filter p =   
      let rec find acc = function     
      |[] -> List.rev acc   
      | x :: xs -> 
        if p x then find (x :: acc) xs 
        else find acc xs  
      in find []

    let rec fold_right f l acc =   
      match l with       
      |h::t -> f h (fold_right f t acc)     
      |[]   -> acc

    let rec fold_left f acc l =
      match l with         
      | h::t -> fold_left f (f acc h) t       
      | []   -> acc

    let countFMFRight ( aElement,aList1 ) = 
      let filteredList = filter (function i -> i=aElement) aList1
      let mappedList =  map (function aEl -> 1) filteredList
      fold_right (+) mappedList 0

    let countFMFLeft ( aElement,aList1 ) = 
      let filteredList = filter (function i -> i=aElement) aList1
      let mappedList =  map (function aEl -> 1) filteredList
      fold_left (+) 0 mappedList

    let sqrFMF aList1 =
      map(fun x->x*x) aList1

    let isPalindromeFMF aList1 = false