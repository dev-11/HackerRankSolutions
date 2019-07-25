from collections import deque
d = deque()
for _ in range(int(input())):
    command = input().split()
    arg= command[1] if len(command) > 1 else ""
    eval("d."+command[0]+"("+ arg +")")
    
print(*d)

