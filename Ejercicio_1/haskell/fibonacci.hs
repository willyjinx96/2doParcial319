--Recursivo
fib :: Integer -> Integer
fib 0 = 0
fib 1 = 1
fib 2 = 1
fib n = fib (n-1) + fib (n-2) + fib(n-3)

main = do
    putStrLn "Introduzca un numero:"
    n <- readLn
    print(map fib [0.. n-1])