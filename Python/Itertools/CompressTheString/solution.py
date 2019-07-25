from itertools import groupby
print(*[(len(list(g)), k) for k, g in groupby(input(), int)])

