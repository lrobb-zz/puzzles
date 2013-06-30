find the Pythagorean triplet
"""
A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,

a2 + b2 = c2
For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

"""

# this one was a bit hard... thanks to 
# http://www.math.brown.edu/~jhs/frintch2ch3.pdf

def main():       

    for v in range (1, 100):
        for u in range(v, 100):
            (a,b,c) = (u**2-v**2, 2*u*v, u**2+v**2)
            if sum([a,b,c]) == 1000:
                print (a*b*c)
                return
        
    
if __name__ == "__main__":
    main()