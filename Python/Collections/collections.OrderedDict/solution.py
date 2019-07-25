from collections import OrderedDict

ordered_dictionary = OrderedDict()
for _ in range(int(input())):
    key, space, value = input().rpartition(' ')
    ordered_dictionary[key] = ordered_dictionary.get(key, 0) + int(value)
    
[print(i, v) for i, v in ordered_dictionary.items()]

