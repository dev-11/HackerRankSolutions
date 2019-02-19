p = int(input())
q = int(input())
numbers = []

for i in range(p, q+1):
    digits = str(i ** 2)
    digits_len = len(digits)
    l_split = digits_len // 2
    r_split = digits_len - l_split
    carry = digits_len % 2
    left = digits[:l_split]
    right = digits[r_split-carry:]
    
    if int(left or 0) + int(right or 0) == i:
        numbers.append(i)

if len(numbers) > 0:
    print(*numbers)
else:
    print("INVALID RANGE")
