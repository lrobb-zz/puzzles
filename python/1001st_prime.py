"""
The 10001st prime

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
we can see that the 6th prime is 13.

What is the 10001st prime number?

"""

def prime (n):
    for i in range (2, int( 1 + (n ** .5))):
        if n % i == 0:
            return False
    return True    
    
def main():       
    
    n = 21
    primes = [2,3,5,7,11,13,17,19]
    while len(primes) < 10001:
        if prime (n):
            primes.append(n)
        n += 2
            
    print primes[10000]
        
    
    
if __name__ == "__main__":
    main()