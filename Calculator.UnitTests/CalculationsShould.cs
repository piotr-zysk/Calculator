using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;
using Xunit.Sdk;
using System.Reflection;

namespace Calculator.UnitTests
{
    class FindPatternDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { "0.3333333", "3" };
            yield return new object[] { "0.10333333", "3" };


            yield return new object[] { "1.1111111", "1" };
            yield return new object[] { "1.1111112", "" };
            yield return new object[] { "1.0101010", "01" };
            yield return new object[] { "1.12312312", "123" };
            yield return new object[] { "1.78978978979", "789" };
        }
    }

    public class CalculationsShould
    {
        [Theory]
        [FindPatternData]
        public void FindPattern(string inputData, string expectedResult)
        {
            Pattern pattern = new Calculations().FindPattern(inputData);
            Assert.Equal(expectedResult, pattern?.Value);
        }
    }
}
