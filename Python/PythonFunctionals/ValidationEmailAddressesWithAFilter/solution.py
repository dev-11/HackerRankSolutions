import re

def fun(s):
    # return True if s is a valid email, else return False
    return bool(re.match(r"^[A-Za-z0-9_-]+@[A-Za-z0-9]+\.[a-zA-Z]{2,3}$", s))

