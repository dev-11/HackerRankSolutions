s1 = set(map(int, input().split()))
print(all(s1.issuperset(set(map(int, input().split()))) for _ in range(int(input()))))

