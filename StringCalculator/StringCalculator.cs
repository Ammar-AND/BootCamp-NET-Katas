using System;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private char[] seperators = new char[] { ',', '\n' };

        public int Add(string inputString)
        {
            var outPut = 0;
            if (string.IsNullOrWhiteSpace(inputString))
                return outPut;
            
            var tupleDelimitorWithData = ExactDelimiterWithData(inputString);
            if(tupleDelimitorWithData != null)
            {
                seperators = tupleDelimitorWithData.Item1;
                inputString = tupleDelimitorWithData.Item2;
            }
           
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


        private Tuple<char[], string> ExactDelimiterWithData(string inputString)
        {

            var data = inputString.Split("\n");
            if (data[0].Length == 3)
            {
                if (data[0][0] == '/' && data[0][1] == '/')

                   return Tuple.Create(new char[] { data[0][2] }, data[1]);
            }

            return null;

        }

    }
}

