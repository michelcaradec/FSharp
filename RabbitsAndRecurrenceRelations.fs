type population = { Adults:int; Newborn:int }
let rabbits n k =
    let rec evalPopulation pop gen =
        match pop with
        | _ when gen = n -> pop
        | { Adults=ad; Newborn=nb } -> evalPopulation { Adults=ad+nb; Newborn=ad*k } (gen+1)
    evalPopulation { Adults=0; Newborn=1} 1

rabbits 5 3
|> printfn "%A"
