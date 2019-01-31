namespace DataStructures

module MyStructures =
    type Stack<'a> =
        | Empty
        | Cons of 'a * Stack<'a>
    
    module Stack =
        open System
        
        let empty = Empty
        let isEmpty = 
            function
                | Empty -> true
                | Cons _ -> false
        let cons x s = Cons (x, s)
        let head =
            function
                | Empty -> raise <| new ArgumentException("Empty list")
                | Cons (x,_) -> x
        let tail =
            function
                | Empty -> raise <| new ArgumentException("Empty list")
                | Cons (_,s) -> s
    
    // Exercise 2.1
    let suffixes x =
        let rec suffixes' x y =
            match y with
            | [] -> List.rev x
            | _::ys -> suffixes' (y::x) ys
        suffixes' [] x
