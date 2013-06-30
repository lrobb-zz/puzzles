"""
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
"""


def prime (n):
    for i in range (2, int( 1 + (n ** .5))):
        if n % i == 0:
            return False
    return True

def find(n):
    d = int((n ** .5) + .5)
    while d > 1:
        if n % d == 0 and prime(d):
            print "d: %s" % d
            break
        d -= 1





# Which leads to an even simpler method, using trial division:

def trial(n):
    d = 2
    while n > 1 :
        while n % d == 0:
            n /= d
        d += 1
    print d - 1
	
	