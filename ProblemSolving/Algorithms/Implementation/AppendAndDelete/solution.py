def common_length(str1, str2):
    min_len = min(len(str1), len(str2))
    for i in range(min_len):
        if(str1[i] != str2[i]):
            return i
    return min_len

s = input()
t = input()
k = int(input())
len_sum = len(s) + len(t)

if len_sum <= k:
    print("Yes")
else:
    common_len = common_length(s,t)
    chars_to_change = len_sum-2*common_len
    print("Yes" if k >= chars_to_change and (k-chars_to_change)%2 == 0 else "No")

