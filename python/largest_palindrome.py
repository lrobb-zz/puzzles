# the largest palindrome made from the product of two 3-digit numbers
"""
A palindromic number reads the same both ways. The largest
palindrome made from the product of two 2-digit numbers is
9009 = 91 x 99.

Find the largest palindrome made from the product of two 3-digit
numbers.

Just a brute force solution:

"""

def palindrome(n):
    n = str(n)
    return n[0:3] == n[3:6][::-1]


def calc(): 
    max = 0
    for d in range(100,1000):
        for n in range(100,1000):
            product = d * n
            if palindrome(product) and product > max: max = product
    print max
 