open System

let rec fibonacci n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | 2 -> 1
    | _ -> fibonacci (n - 1) + fibonacci (n - 2) + fibonacci (n - 3)

[<EntryPoint>]
let main argv =
    let num = Console.ReadLine()
    let nums=[0..int(num)-1]
    let finres = List.map fibonacci nums
    printfn "%A" finres
    let tecla = Console.ReadKey()
    0 // return an integer exit code