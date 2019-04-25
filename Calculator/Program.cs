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
            int A, B;

            try
            {
                A = int.Parse(args[0]);
                B = int.Parse(args[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }


            var result = new Calculations().Divide(A, B);
            Console.WriteLine($"{A} / {B} = {result}");
        }
    }
}
