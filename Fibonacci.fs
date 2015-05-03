let fib = 
    Seq.unfold 
        (fun (fst, snd) -> Some (fst + snd, (snd, fst + snd)))
        (0, 1)

let fib10 = 
    fib
    |> Seq.take 10
    |> Seq.toList

printf "first 10 fibs are %A" fib10
