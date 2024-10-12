Here is a Java console application that counts the number of palindromic substrings in a given string.

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a string:");
        String input = scanner.nextLine();
        System.out.println("Number of palindromic substrings: " + countPalindromicSubstrings(input));
    }

    private static int countPalindromicSubstrings(String s) {
        int n = s.length();
        boolean[][] dp = new boolean[n][n];
        int count = 0;

        for (int g = 0; g < n; g++) {
            for (int i = 0, j = g; j < n; i++, j++) {
                if (g == 0) {
                    dp[i][j] = true;
                } else if (g == 1) {
                    dp[i][j] = s.charAt(i) == s.charAt(j);
                } else {
                    dp[i][j] = s.charAt(i) == s.charAt(j) && dp[i + 1][j - 1];
                }

                if (dp[i][j]) {
                    count++;
                }
            }
        }

        return count;
    }
}
```

This program reads a string from the console input, then it counts the number of palindromic substrings in the string using dynamic programming. The count is then printed to the console.