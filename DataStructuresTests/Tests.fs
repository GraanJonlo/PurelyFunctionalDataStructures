module Tests

open Xunit
open FsUnit.Xunit

open DataStructures.MyStructures

[<Fact>]
let ``Empty stack is empty`` () =
    Stack.isEmpty Empty |> should be True

[<Fact>]
let ``Constructs a new stack`` () =
    Stack.cons 1 Empty |> should equal (Cons (1, Empty))

[<Fact>]
let ``Gets the head`` () =
    Stack.head (Cons (1, Empty)) |> should equal 1

[<Fact>]
let ``Gets the tail`` () =
    Stack.tail (Cons (1, Cons (2, Empty))) |> should equal (Cons (2, Empty))

// Exercise 2.1
[<Fact>]
let ``Gets suffixes`` () =
    suffixes [1;2;3] |> should equal [[1;2;3];[2;3];[3]]
