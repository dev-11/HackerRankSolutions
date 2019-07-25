def swap_case(s):
    str = ""
    for c in s:
        if c.islower():
            str += (c.upper())
        else:
            str += (c.lower())
            
    return str

