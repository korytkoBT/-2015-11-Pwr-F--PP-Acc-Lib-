namespace BT.Rec_Branch
  module Element=

  let rec duplicate (aToReply,aCounter) = 
   if aCounter=0 then []
   else aToReply::duplicate(aToReply,aCounter-1)

