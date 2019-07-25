from itertools import combinations_with_replacement

s, n = input().split()
print("\n".join(''.join(p) for p in list(combinations_with_replacement(sorted(s),int(n)))))

