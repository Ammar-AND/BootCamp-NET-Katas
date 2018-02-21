using System;
using Xunit;
using FluentAssertions;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        private StringCalculator.StringCalculator Calcuator;
        public StringCalculatorTests()
        {
            Calcuator = new StringCalculator.StringCalculator();
        }

        [Fact]
        public void TestCalculatorForEmptyString()
        {
            var ret = Calcuator.Add("");
            ret.Should().Be(0);

        }

        [Fact]
        public void ShouldReturnTheSumOfOneValue()
        {
            int  expected = 1;

            var actual = Calcuator.Add("1");

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnZeroOnString()
        {
            int expected = 0;

            var actual = Calcuator.Add("asr");

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnValidNUmberIfOtherIsInvalid()
        {
            int expected = 3;

            var actual = Calcuator.Add("as3,3");

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnTheSumOfTwoValues()
        {
            int expected = 5;

            var actual = Calcuator.Add("2,3");

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnZeroOnEmpty()
        {
            int expected = 0;

            var actual = Calcuator.Add(string.Empty);

            actual.Should().Be(expected);

        }



    }
}
