using System;
using System.Linq;

namespace Palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            var reversed = new string(input.ToCharArray().Reverse().ToArray());
            return input == reversed;
        }
    }
}
