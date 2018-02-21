using System;
using Xunit;
using Palindrome;
using FluentAssertions;


namespace PalindromeTests
{
    public class PalindromShould
    {
        Palindrome.Palindrome Palindrome;
        public PalindromShould()
        {
            Palindrome = new Palindrome.Palindrome();
        }
        [Fact]
        public void IsEmptyStringNotAPalindrom()
        {
            var input = string.Empty;
            var result = Palindrome.IsPalindrome(input);

            result.Should().BeFalse();
        }
        [Fact]
        public void IsOneLetterAPalindrom()
        {
            var oneLetter = "a";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }

        [Fact]
        public void IsOneWhiteSpaceAPalindrom()
        {
            var oneLetter = " ";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }

        [Fact]
        public void IsValidEvenStringAPalindrom()
        {
            var oneLetter = "anddna";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }

        [Fact]
        public void IsValidOddStringAPalindrom()
        {
            var oneLetter = "andadna";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }

        [Fact]
        public void IsAtSymbelAPalindrom()
        {
            var oneLetter = "an@na";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }

        [Fact]
        public void IsInvalidAPalindrom()
        {
            var oneLetter = "an@na1an@naa";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeFalse();

        }

        [Fact]
        public void IsNumericValidPalindrom()
        {
            var oneLetter = "123321";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }

        [Fact]
        public void IsSpaceBetweenLettersValidPalindrom()
        {
            var oneLetter = "123 321";
            var result = Palindrome.IsPalindrome(oneLetter);

            result.Should().BeTrue();

        }


    }
}
