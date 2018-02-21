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
        public void ShouldReturnZeroOnEmpty()
        {
            int expected = 0;

            var actual = Calcuator.Add(string.Empty);

            actual.Should().Be(expected);

        }


        [Fact]
        public void ShouldReturnZeroOnNull()
        {
            int expected = 0;

            var actual = Calcuator.Add(null);

            actual.Should().Be(expected);

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
        public void ShouldReturnTheSumOfTwoValues()
        {
            int expected = 5;

            var actual = Calcuator.Add("2,3");

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnValidNUmberIfOtherIsInvalid()
        {
            int expected = 0;

            var actual = Calcuator.Add("as3,3");

            actual.Should().Be(expected);

        }


        [Fact]
        public void ShouldReturnZeroOnBothInvalidNumbers()
        {
            int expected = 0;

            var actual = Calcuator.Add("as3,$");

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnZeroOnInvalidSeperator()
        {
            int expected = 0;

            var actual = Calcuator.Add("2^5");

            actual.Should().Be(expected);

        }


        [Fact]
        public void ShouldAddAnyNumberOfValues()
        {
            int expected = 4;

            var actual = Calcuator.Add("1,1,1,1");

            actual.Should().Be(expected);

        }


        [Fact]
        public void ShouldAddValuesWithNewLineCharater()
        {
            int expected = 8;

            var testInput = "1\n3,4";
            
            var actual = Calcuator.Add(testInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturnZeroWithNewLineAndAdditionalSeperators()
        {
            int expected = 0;

            var testInput = ",,\n1\n3,4\n";

            var actual = Calcuator.Add(testInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturn3WithSemicolonAsSeperator()
        {
            int expected = 3;

            var testInput = "//;\n1;2";

            var actual = Calcuator.Add(testInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturn0WithWrongSeperator()
        {
            int expected = 0;

            var testInput = "//;\n1,2";

            var actual = Calcuator.Add(testInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ShouldReturn0WithMissingLineBreakSeperator()
        {
            int expected = 0;

            var testInput = "//;1;2";

            var actual = Calcuator.Add(testInput);

            actual.Should().Be(expected);

        }

    }
}
