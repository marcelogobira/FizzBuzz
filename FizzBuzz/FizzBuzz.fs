module FizzBuzz

let iterar i = 
        let mutable saida : string = "";
        
        if(i % 3 = 0) then
          saida <- saida + "Fizz";
        if(i % 5 = 0) then
          saida <- saida + "Buzz";
        if(saida = "") then
          saida <- string i;
           
        //printf "%s \n" saida;
        return saida

