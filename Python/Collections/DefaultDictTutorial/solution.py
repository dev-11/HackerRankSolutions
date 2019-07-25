from collections import defaultdict
d = defaultdict(list)
n,m = map(int, input().split())

for i in range(n):
    d[input()].append(i+1)

for _ in range(m):
    print(' '.join(map(str, d[input()])) or -1)


