_ =input()
s1, s2 = set(), set()

for i in input().split():
    if  i in s1: #duplicates
        s2.add(i)
    else: # uniques
        s1.add(i)

print(*s1.difference(s2))

