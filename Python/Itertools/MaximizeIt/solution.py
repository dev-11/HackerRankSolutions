from itertools import product

loop, modulo = map(int, input().split())
lst = [map(int, input().split()[1:]) for _ in range(loop)]
print(max(map(lambda x: sum(i**2 for i in x)%modulo, product(*lst))))

