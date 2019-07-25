_ = input()
arr = map(int, input().split())
s1 = set(map(int, input().split()))
s2 = set(map(int, input().split()))
print(sum((i in s1) - (i in s2) for i in arr))

