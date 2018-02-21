using System;

namespace StringCalculator
{
    public class StringCalculator
    {
        private const char Seperator = ',';
        public int Add(string inputString)
        {
            var parsedNumbers = inputString.Split(new char[] { Seperator });
            if(parsedNumbers.Length == 1)
            {
                int parsedNum;
                if (int.TryParse(parsedNumbers[0], out parsedNum))
                    return parsedNum;
            }
            return 0;
        }
    }
}
