open FizzBuzz
// Learn more about F# at http://fsharp.org

open System
//open NUnit.Framework
//open FsUnit

[<EntryPoint>]
let main argv =

    //Decalrações
    let mutable x : int = 0;

    let pedirNumero = 
        printfn "Por vafor digite um número maior que zero."
        x <- System.Console.ReadLine() |> int;
        
    

    let imprimirCabecalho x = 
        printf "###################################\n";
        printf "# Imprimindo FizzBuzz de 1 até %i #\n" x;
        printf "###################################\n\n\n";
       
    
    //Início
    while x < 1 do
        pedirNumero

    imprimirCabecalho x;

    [1..x] |> List.map FizzBuzz.iterar;

    let l = System.Console.ReadLine();
    
    0 // return an integer exit code
