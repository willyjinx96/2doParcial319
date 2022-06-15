fibo = map fst (iterate f (0, 1)) where f (a,b) = (b,a+b)

main = do
    print "Introduzca un numero: "
    num <- getLine
    print(take (read num) fibo)