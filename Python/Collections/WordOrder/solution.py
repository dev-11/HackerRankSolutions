from collections import OrderedDict
words = OrderedDict()
for _ in range(int(input())):
    eachword = input().strip()
    words[eachword] = words.get(eachword, 0) + 1
    
print(len(words))
print(*words.values())

