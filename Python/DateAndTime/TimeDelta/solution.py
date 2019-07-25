from datetime import datetime as dt

for _ in range(int(input())):
    fmt = '%a %d %b %Y %H:%M:%S %z'
    print(int(abs((dt.strptime(input(), fmt) - 
                    dt.strptime(input(), fmt)).total_seconds())))

