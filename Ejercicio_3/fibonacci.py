def fibonacci(n):
    def op(a, b, c):
        return b, c, a+b+c

    def combinar(initial, op, n):
        a, b, c = initial
        for i in range(n):
            a, b, c = op(a, b, c)
        return b

    if n == 0:
        return 0
    if n == 1:
        return 1
    if n == 2:
        return 1

    return combinar((0, 1, 1), op, n - 1)


print("Fibonacci con funciones de orden Superior")
n = int(input("Introduzca un numero: "))
for i in range(n):
    print(fibonacci(i), end=" ")
