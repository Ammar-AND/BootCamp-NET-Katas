using System;

namespace StringCalculator
{
    public class StringCalculator
    {
        private const char Seperator = ',';
        public int Add(string inputString)
        {
            var parsedNumbers = inputString.Split(new char[] { Seperator });


            if (parsedNumbers.Length == 1)
            {
                int parsedNum;
                if (int.TryParse(parsedNumbers[0], out parsedNum))
                    return parsedNum;
            }
              else  if(parsedNumbers.Length  == 2)
            {
                int parsedNum1;
                int parsedNum2;

                int.TryParse(parsedNumbers[0], out parsedNum1);
                int.TryParse(parsedNumbers[1], out parsedNum2);

                return  parsedNum1 + parsedNum2;
            }


            return 0;
        }
    }
}
