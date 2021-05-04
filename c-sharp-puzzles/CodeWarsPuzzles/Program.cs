using System;

namespace CodeWarsPuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // function to determine if string is a palindrome
        // https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp
        static bool isPanagram(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            foreach (char c in alphabet)
            {
                foreach (char check in str.ToLower())
                {
                    if (c == check)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == 26)
            {
                return true;
            } else 
            {
                return false;
            }
        }


        /* Can a clerk sell a ticket to every person and give change 
            if he initially has no money and sells the tickets strictly 
            in the order people queue? */
        // https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8/train/csharp
        static string tickets(int[] peopleInLine)
        {
            int cost = 25;
            int till = 0;
            int change = 0;

            foreach (int patron in peopleInLine)
            {
                change = patron - cost;
                if (change > till)
                {
                    return "NO";
                }
                till += cost;
            }
            return "YES";
        }
    }
}
