funSup ::(Integer -> Integer -> String)->Integer->Integer->String

funSup f x y = f x y

fib :: Integer -> Integer

fib 0 = 0
fib 1 = 1
fib 2 = 1
fib n = fib (n-1) + fib (n-2) + fib(n-3)

fibonacci :: Integer -> Integer -> String

fibonacci n nMax =
    if n < nMax-1 then
      show (fib n) ++ " " ++ fibonacci (succ n) nMax
    else
      show (fib n)

main = do
    putStrLn "Introduzca un numero:"
    n <- readLn
    print (funSup fibonacci 0 (n))