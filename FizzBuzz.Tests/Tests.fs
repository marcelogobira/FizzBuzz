module Tests

open System
open Xunit
open FizzBuzz

[<Fact>]
let ``My test`` () =
    Assert.True(true)

//[<Test>]
    //let fizz() =
    //    let expected = iterar(9)
    //    Assert.AreEqual(expected, "Fizz")
    
    //[<Test>]
    //let buzz() =
    //    let expected = iterar(10)
    //    Assert.AreEqual(expected, "Buzz")
    //[<Test>]
    //let fizzbuzz() =
    //    let expected = iterar(15)
    //    Assert.AreEqual(expected, "FizzBuzz")
    //[<Test>]
    //let numberString() =
    //    let expected = iterar(11)
    //    Assert.AreEqual(expected, "11")
