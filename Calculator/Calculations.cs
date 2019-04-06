using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        public string Run(int a, int b)
        {
            decimal DivideResult = (decimal)a / b;
            string DivideResultString = DivideResult.ToString();

            return DivideResultString; //to be changed with calculation result
        }

        public Pattern FindPattern(string InputString)
        {


            return new Pattern("01", 1);
        }
    }
}
