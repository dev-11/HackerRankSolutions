def isInOrder(columns):
    for index in range(len(columns)):
        if sorted(columns[index]) != columns[index]:
            return False
    return True

grids = int(input())
for _ in range(grids):
    grid = (sorted(input()) for _ in range(int(input())))
    columns = [list(x) for x in zip(*grid)]
    
    print("YES" if isInOrder(columns) else "NO")
