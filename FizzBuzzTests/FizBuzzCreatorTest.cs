using FluentAssertions;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizBuzzCreatorTest
    {
        FizzBuzzCreator FizzBuzz;

       public FizBuzzCreatorTest()
        {
           FizzBuzz = new FizzBuzzCreator();
        }

        [Fact]
        public void DoesReturnString()
        {            
            var result = FizzBuzz.getFizzBuzz();
            result.Should().BeOfType(typeof(string));   
        }

        [Fact]
        public void DoesDivedBy3ReturnFizz()
        {            
            var result = FizzBuzz.getFizzBuzz();
            var FirstFizz = result.Substring(2, 4);
            FirstFizz.Should().Be("Fizz");
        }

        [Fact]
        public void DoesDivedB3ReturnBuzz()
        {
            var result = FizzBuzz.getFizzBuzz();
            var FirstBuzz = result.Substring(7, 4);
            FirstBuzz.Should().Be("Buzz");
        }

        [Fact]
        public void DoesDivedBy5And3ReturnFizzBuzz()
        {
            var result = FizzBuzz.getFizzBuzz();
            var FirstfizzBuzz = result.Substring(35, 8);
            FirstfizzBuzz.Should().Be("FizzBuzz");
        }

        [Fact]
        public void IsLastFizzBuzz()
        {
            var result = FizzBuzz.getFizzBuzz();
            var FirstfizzBuzz = result.Substring(result.Length-8, 8);
            FirstfizzBuzz.Should().Be("FizzBuzz");
        }
    }
}
