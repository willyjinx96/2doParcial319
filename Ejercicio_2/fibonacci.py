from functools import reduce


def fib(n): return reduce(lambda x, _: x+[x[-1]+x[-2]+x[-3]],
                          range(n-3), [0, 1, 1])


print("Fibonacci Lambda")
n = int(input("Introduzca un numero: "))
print(fib(n))
