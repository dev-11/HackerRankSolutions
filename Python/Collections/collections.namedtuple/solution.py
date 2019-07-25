loop, index = int(input()), input().split().index("MARKS")
summary = sum([int(input().split()[index]) for _ in range(loop)])
print(summary/loop)

