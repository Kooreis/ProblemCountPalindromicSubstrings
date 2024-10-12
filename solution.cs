```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Number of palindromic substrings: " + CountPalindromicSubstrings(input));
    }

    static int CountPalindromicSubstrings(string s)
    {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        int count = 0;

        for (int g = 0; g < n; g++)
        {
            for (int i = 0, j = g; j < n; i++, j++)
            {
                if (g == 0)
                {
                    dp[i, j] = true;
                }
                else if (g == 1)
                {
                    if (s[i] == s[j])
                    {
                        dp[i, j] = true;
                    }
                }
                else
                {
                    if (s[i] == s[j] && dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                    }
                }

                if (dp[i, j])
                {
                    count++;
                }
            }
        }

        return count;
    }
}
```