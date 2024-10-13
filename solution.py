def count_palindromic_substrings(s):
    count = 0
    for center in range(2*len(s)-1):
        left = center // 2
        right = left + center % 2