using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Number of palindromic substrings: " + CountPalindromicSubstrings(input));
    }
}