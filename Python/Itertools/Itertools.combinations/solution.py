from itertools import combinations

s, n = input().split()
for i in range(1,int(n)+1):
    print("\n".join([(''.join(p)) for p in combinations(sorted(s), i)]))

