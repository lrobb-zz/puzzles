smallest positive number that is evenly divisible by all of the numbers from 1 to 20
"""

2520 is the smallest number that can be divided by each of
the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly
divisible by all of the numbers from 1 to 20?

"""

# ughhh... could've been simpler, but
# I went with a lookup table
#

"""

the smart way:

def gcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

def lcm(a, b):
    return a*b/gcd(a, b)

print reduce(lcm, range(1, 20+1)) 

"""

from operator import mul


def primes():
    numbers = range (2,101)
    prime = 2
    i = 1
    while (prime*prime < 101):
        numbers = filter(lambda x: x % prime != 0 or x == prime, numbers)
        prime = numbers[i]
        i += 1
    return numbers
   
def factor(table, prime):   
    divisible = True
    done = False
   
    while divisible:   
        divisible = False
        done = True
       
        for key in table.keys():           
            if key == 0:
                table[0].append (prime) 
                continue
               
            if (table[key][-1] % prime == 0 and prime <= table[key][-1]):
                table[key].append (table[key][-1]/prime)
                divisible = (table[key][-1] % prime == 0 or prime <= table[key][-1])
               
            else:
                table[key].append (table[key][-1])

            if table[key][-1] > 1:
                done = False

    return done
       
def main():     
    table = {}
   
    for n in range (0,21):
        table[n] = [n]

    for prime in primes():
        if factor(table, prime) == True:
            break
   
    prod = reduce(mul, table[0][1:len(table[0])])
    print prod


   
if __name__ == "__main__":
    main()