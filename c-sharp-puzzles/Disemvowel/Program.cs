using System;
using System.Text.RegularExpressions;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(disemvowel("Hello WOrld!"));
        }
        // function that removes all vowels from a string ignoring case
        // https://www.codewars.com/kata/52fba66badcd10859f00097e/train/csharp
        static string disemvowel(string str)
        {
            str = Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
            return str;
        }
    }
}
