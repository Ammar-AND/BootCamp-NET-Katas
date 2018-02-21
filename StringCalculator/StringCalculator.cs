using System;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private readonly char[] seperators = new char[] { ',', '\n' };

        public int Add(string inputString)
        {
            var outPut = 0;
            if (string.IsNullOrWhiteSpace(inputString))
                return outPut;

            try
            {
                outPut = int.Parse(inputString.Split(seperators)
                    .Aggregate((x, y) => (int.Parse(x) + int.Parse(y)).ToString()));             
            }
            catch( Exception ex)
            {
                //Log
                return outPut = 0;
            }

            return outPut;
        }
    }
}
