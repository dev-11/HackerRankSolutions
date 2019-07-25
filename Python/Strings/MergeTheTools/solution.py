def merge_the_tools(string, k):
    [print("".join(sorted(set(part), key=part.index))) for part in [string[i:i+k] for i in range(0, len(string), k)]]

