using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        public string Divide(int a, int b)
        {
            decimal DivideResult = (decimal)a / b;
            string DivideResultString = DivideResult.ToString();

            var dotPosition = DivideResultString.IndexOf('.');
            var fraction = DivideResultString.Substring(dotPosition + 1);

            Pattern pattern = FindPattern(fraction);

            string result;
            if (pattern.Value == "") result = DivideResultString;
            else result = DivideResultString.Substring(0, dotPosition + 1 + pattern.IndexOf)
                    + $"({pattern.Value})";

            return 
                //$"{DivideResultString} -> recurring '{pattern.Value}' -> " +
                result;
        }

        // find decimal period
        public Pattern FindPattern(string inputString)
        {
            int position;
            var length = 1;
            string pattern, fractionSincePatternStart;

            for (int i = 0; i< Math.Floor((decimal)inputString.Length/length); i++)
            {
                position = i * length;
                pattern = inputString.Substring(position, length);
                fractionSincePatternStart = inputString.Substring(position);

                var expectedString = inputString.Substring(0, position)
                    + string.Concat(Enumerable.Repeat(pattern, ExpectedPatternCount(fractionSincePatternStart, length)))
                    + ExpectedTail(fractionSincePatternStart, pattern);

                if (inputString == expectedString) return new Pattern(pattern, position);
            }

            return new Pattern("", 0);
        }

        private int ExpectedPatternCount(string fraction, int patternLength)
        => (int)Math.Floor((decimal)fraction.Length / patternLength);

        private int TailLength(string fraction, int patternLength)
            => fraction.Length - (patternLength * ExpectedPatternCount(fraction, patternLength));
        private string ActualTail(string fraction, int patternLength)
            => fraction.Substring(patternLength * ExpectedPatternCount(fraction, patternLength));
           
        private string ExpectedTail(string fraction, string pattern)
        {
            string temp = ActualTail(fraction,pattern.Length);
            if (temp == "") return "";

            temp += temp;
            
            var tempNumber = long.Parse(temp);
            decimal roundNumber = (decimal)Math
                    .Round(tempNumber /
                    Math.Pow(10, temp.Length - TailLength(fraction, pattern.Length)));

            return roundNumber.ToString().PadLeft(TailLength(fraction,pattern.Length), '0');
        }
       
    }
}
