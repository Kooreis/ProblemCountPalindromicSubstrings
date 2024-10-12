def count_palindromic_substrings(s):
    count = 0
    for center in range(2*len(s)-1):
        left = center // 2
        right = left + center % 2
        while left >= 0 and right < len(s) and s[left] == s[right]:
            count += 1
            left -= 1
            right += 1
    return count

def main():
    s = input("Enter a string: ")
    print("Number of palindromic substrings: ", count_palindromic_substrings(s))

if __name__ == "__main__":
    main()