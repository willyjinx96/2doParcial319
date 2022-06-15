namespace fiboLib

//Recursivo
module fibonacci =
    let rec fiboRec n =
        match n with
        | 0 -> 0
        | 1 -> 1
        | 2 -> 1
        | _ -> fibonacci (n - 1) + fibonacci (n - 2) + fibonacci (n - 3)
        
//Estructurado
    let fiboEst n =
        let mutable a=(-1)
        let mutable b=1
        let mutable c=0
        let mutable f=0
        for i in 1..(n-1) do
            a<-b
            b<-c
            c<-f
            f<-a+b+c
        f