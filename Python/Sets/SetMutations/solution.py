_, s = input(), set(map(int, input().split()))
for _ in range(int(input())):
    eval("s."+input().split()[0]+"(map(int, input().split()))")

print(sum(s))

