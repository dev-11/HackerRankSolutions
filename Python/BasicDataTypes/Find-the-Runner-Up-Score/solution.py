if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().split()))
    
    max_number = max(arr)
    
    for i in range(0,len(arr)):
        if arr[i] == max_number:
            arr[i] = -10000000
    
    print(max(arr))

