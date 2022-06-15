open System

let rec fibonacci n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | 2 -> 1
    | _ -> fibonacci (n - 1) + fibonacci (n - 2) + fibonacci (n - 3)

let fibo n =
      let mutable a=(-1)
      let mutable b=1
      let mutable c=0
      let mutable d=0
      for i in 1..(n-1) do
        a<-b
        b<-c
        c<-d
        d<-a+b+c        
      d

[<EntryPoint>]
let main argv =
    let num = Console.ReadLine()
    let nums=[0..int(num)-1]
    let finres = List.map fibonacci nums
    printfn "%A" finres
    let fines = List.map fibo nums
    printfn "%A" fines
    let tecla = Console.ReadKey()
    0 // return an integer exit code