for _ in range(int(input())):
    _, s1 = input(), set(map(int, input().split()))
    _, s2 = input(), set(map(int, input().split()))
    print(s1.issubset(s2))

