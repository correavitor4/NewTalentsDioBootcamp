using System;
using NewTalentsDioBootcamp;
using Xunit;

namespace TestNewTalentsDioBootcamp
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSum(int val1, int val2, int expectedResult)
        {
            var calc = new Calculator();

            var res = calc.Sum(val1, val2);

            Assert.Equal(expectedResult, res);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(11, 5, 6)]
        public void TestSubtract(int val1, int val2, int expectedResult)
        {
            var calc = new Calculator();

            var res = calc.Subtract(val1, val2);

            Assert.Equal(expectedResult, res);
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiply(int val1, int val2, int expectedResult)
        {
            var calc = new Calculator();

            var res = calc.Multiply(val1, val2);

            Assert.Equal(expectedResult, res);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(10, 3, 3)]
        public void TestDivision(int val1, int val2, int expectedResult)
        {
            var calc = new Calculator();

            var res = calc.Divide(val1, val2);

            Assert.Equal(expectedResult, res);
        }

        [Fact]
        public void TestDivisionPerZero()
        {
            var calc = new Calculator();

            Assert.Throws<DivideByZeroException>(() =>
            {
                calc.Divide(3, 0);
            });
        }
    }
}
