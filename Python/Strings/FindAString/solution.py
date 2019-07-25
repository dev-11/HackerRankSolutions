import re

def count_substring(string, sub_string):
    return len(re.findall('(?={0})'.format(sub_string), string))

