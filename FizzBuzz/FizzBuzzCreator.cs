using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzCreator
    {
        private string FizzBuzz(int value)
        {
            if (value % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (value % 3 == 0)
            {
                return "Fizz";
            }
            if (value % 5 == 0)
            {
                return "Buzz";
            }
            return value.ToString();
        }

        public string getFizzBuzz()
        {
            string FizzBuzzString = "";
            foreach (var val in Enumerable.Range(1, 100).Select(n => FizzBuzz(n)))
                FizzBuzzString += val;
            return FizzBuzzString;
        }
    }
}