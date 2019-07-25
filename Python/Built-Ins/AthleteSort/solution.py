N, _ = map(int, input().split())
rows = [input() for _ in range(N)]
K = int(input())

[print(row) for row in sorted(rows, key=lambda r: int(r.split()[K]))]

