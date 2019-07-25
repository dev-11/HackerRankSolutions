import collections

_ = int(input())
shoes = collections.Counter(map(int, input().split()))

s = 0

for _ in range(int(input())):
    n,m = map(int, input().split())
    if shoes[n]:
        s += m
        shoes[n] -= 1

print(s)

