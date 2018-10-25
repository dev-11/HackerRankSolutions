_ = input()
arr = list(map(int, input().split()))

p=arr[0]
left,right, result=[],[],[]

for _ in arr:
    if _ >= p:
        right.append(_)
    elif _ <p:
        left.append(_)

for _ in left:
    result.append(_)  
for _ in right:
    result.append(_)
    
print(*result)
