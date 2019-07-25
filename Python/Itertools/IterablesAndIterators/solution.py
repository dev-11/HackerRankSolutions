from itertools import combinations
N,L,K = int(input()), input().split(), int(input())
C = list(combinations(L, K))
print(len(list(filter(lambda c: 'a' in c, C)))/len(C))

