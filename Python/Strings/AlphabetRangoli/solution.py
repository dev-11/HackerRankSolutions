import string

def print_rangoli(size):
    
    # your code goes here
    alpha = string.ascii_lowercase
    r = []
    for i in range(n):
        s = "-".join(alpha[i:n])
        r.append((s[::-1]+s[1:]).center(4*n-3, "-"))
        
    print("\n".join(r[:0:-1]+r))

