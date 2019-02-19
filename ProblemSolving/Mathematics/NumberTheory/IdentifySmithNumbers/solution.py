number = input()
prime_factor = []
n = int(number)
i = 2
while i * i <= n:
    if n % i:
        i += 1
    else:
        n //= i
        prime_factor.append(i)
if n > 1:
    prime_factor.append(n)

sum_of_digits = sum(map(int,list(number)))
sum_of_factors = sum([sum(map(int,list(str(prime_factor[i])))) for i in range(len(prime_factor))])

print(int(sum_of_factors == sum_of_digits))
