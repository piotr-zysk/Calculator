using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Calculations().Run(1, 30);
            Console.WriteLine(result);
        }
    }
}
