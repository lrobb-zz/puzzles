# the sum of all primes below 2M
"""
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
"""

import cProfile


def prime (n):
    for i in range (2, int( 1 + (n ** .5))):
        if n % i == 0:
            return False
    return True    
    
def find():  
     
    n = 21
    primes = [2,3,5,7,11,13,17,19]
    total = sum(primes)
    while n < 2000*1000:
        if prime (n):
            total += n
        n += 2
    print total

def main():
    cProfile.run('find()')
    
if __name__ == "__main__":
    main()