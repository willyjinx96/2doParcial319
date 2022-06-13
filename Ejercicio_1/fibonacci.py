n = int(input("Ingrese un numero para la secuencia: "))

# Estructurado
print("Fibonacci Estructurado")
a,b,c=0,1,1
for i in range(n):
    f = a
    print(f,end=" ")
    f= a+b+c
    a=b
    b=c
    c=f
    
# Recursivo
print("\nFibonacci Recursivo")
def recur_fibo(n):
    if n == 0:
        return 0
    if n == 1:
        return 1
    if n == 2:
        return 1
    return(recur_fibo(n-1) + recur_fibo(n-2) + recur_fibo(n-3))

for i in range(n):
    print(recur_fibo(i), end=" ")