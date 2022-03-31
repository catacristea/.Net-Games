using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {


        public static (bool, int) IsPalindrome (string input) // tuple - return two values
        {
            //input = Regex.Replace(input, @"[^A-Za-z]", string.Empty); // regex method
            input = String.Join("", input.Where(char.IsLetterOrDigit)); // linq method
            char[] cArr = input.ToCharArray();
            Array.Reverse(cArr);
            string reversedInput = new string(cArr);
            if (input.ToLower() == reversedInput.ToLower())
            {
                return (true, input.Length);
            }
            return (false, 0);
        }
        static void Main(string[] args)
        {
            //code verify in a word or a sentence is palindorme.
            Console.WriteLine("Let's begin:");
            while (true)
            {
            string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
            Console.WriteLine($"Palindrome: {IsPalindrome(input).Item1}, Length: {IsPalindrome(input).Item2}");
            }

        }
    }
}
