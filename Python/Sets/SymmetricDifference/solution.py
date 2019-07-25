_, s1 = input(), set(map(int, input().split()))
_, s2 = input(), set(map(int, input().split()))

print(*sorted(s2.symmetric_difference(s1)), sep="\n")

