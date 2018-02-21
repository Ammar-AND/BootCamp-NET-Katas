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


    }
}
