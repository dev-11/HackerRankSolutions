from itertools import permutations

a,b = input().split()

print(*[''.join(i) for i in permutations(sorted(a),int(b))],sep='\n')

