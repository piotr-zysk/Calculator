using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;

namespace Calculator.UnitTests
{
    public class CalculationsShould
    {
        [Fact]
        public void GetByLogint()
        {
            Pattern pattern = new Calculations().FindPattern("0.333333");
            Assert.Equal("01", pattern?.Value);
        }
    }
}
