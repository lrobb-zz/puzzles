# from itertools import permutations

# def brute_force():
#   TODO: insert rainbow table logic here
#     words = [''.join(p) for p in permutations('acdegilmnoprstuw')]
#     for word in words:
#         if hash(word) == 680131659347:
#             print word

'''


'''

def hash (s):
    h = 7
    letters = 'acdegilmnoprstuw'
    for idx, val in enumerate(s):
        h = (h * 37 + letters.index(val))
        # print h
    return h


def rev (h):
    string = ''
    letters = 'acdegilmnoprstuw'
    while (h > 7):
        idx = h % 37
        h = (h - idx) / 37
        string = letters[idx] + string
    return string

res = rev(935192105418138)
print res
assert hash ('leepadg') == 680131659347
assert hash(res) == 935192105418138