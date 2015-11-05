namespace BT.Matcher
    module Element=
    
    let rec duplicateM (aToReply,aCounter) = 
        match aCounter with
        |0 -> []
        |_ -> aToReply::duplicateM(aToReply,aCounter-1)
    
    