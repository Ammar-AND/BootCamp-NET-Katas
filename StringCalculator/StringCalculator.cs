using System;

namespace StringCalculator
{
    public class StringCalculator
    {
        private const char Seperator = ',';
        public int Add(string inputString)
        {
            var outPut = 0;
            if (string.IsNullOrWhiteSpace(inputString))
                return outPut;

            var parsedNumbers = inputString.Split(new char[] { Seperator });
           
            foreach(var stringVal in parsedNumbers)
            {
                int parsedNum;
                if (int.TryParse(stringVal, out parsedNum))
                    outPut += parsedNum;
            }
            
            return outPut;
        }
    }
}
