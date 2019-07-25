_, rows = map(int, input().split())

print(*[sum(item)/rows for item in zip(*[map(float, input().split()) for _ in range(rows)])], sep="\n")

