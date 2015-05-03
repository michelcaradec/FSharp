let isPalindrom (str: string) =
    let len = str.Length
    let rec check i =
        let left = i
        let right = len - 1 - i
        let len' = right - left + 1

        match len' with
        | 0 -> true
        | 1 -> true
        | _ when str.[left] = str.[right] -> check (i + 1)
        | _ -> false

    match len with
    | 0 -> true
    | _ -> check 0

"mayamoodybabydoomayam"
|> isPalindrom
|> printf "%A"
