using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Pattern
    {
        public int IndexOf { get; set; }
        public string Value { get; set; }

        public Pattern(string value, int position=0)
        {
            this.IndexOf = position;
            this.Value = value;
        }
    }
}
