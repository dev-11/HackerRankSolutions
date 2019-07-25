n = int(input())
s = set(map(int, input().split()))

for _ in range(int(input())):
    command = input().split()
    eval('s.{0}({1})'.format(*command+['']))
    
print(sum(s))

