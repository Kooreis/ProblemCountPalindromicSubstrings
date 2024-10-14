while left >= 0 and right < len(s) and s[left] == s[right]:
            count += 1
            left -= 1
            right += 1