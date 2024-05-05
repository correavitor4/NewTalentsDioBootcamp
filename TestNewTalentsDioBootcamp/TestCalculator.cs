using System;
using System.Security.Cryptography.X509Certificates;
using NewTalentsDioBootcamp;
using Xunit;

namespace TestNewTalentsDioBootcamp
{
    public class TestCalculator
    {

        public Calculator InstantiateClass()
        {
            var data = DateTime.Now.ToShortDateString();
            var calc = new Calculator(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSum(int val1, int val2, int expectedResult)
        {
            var calc = InstantiateClass();

            var res = calc.Sum(val1, val2);

            Assert.Equal(expectedResult, res);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(11, 5, 6)]
        public void TestSubtract(int val1, int val2, int expectedResult)
        {
            var calc = InstantiateClass();

            var res = calc.Subtract(val1, val2);

            Assert.Equal(expectedResult, res);
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiply(int val1, int val2, int expectedResult)
        {
            var calc = InstantiateClass();

            var res = calc.Multiply(val1, val2);

            Assert.Equal(expectedResult, res);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(10, 3, 3)]
        public void TestDivision(int val1, int val2, int expectedResult)
        {
            var calc = InstantiateClass();

            var res = calc.Divide(val1, val2);

            Assert.Equal(expectedResult, res);
        }

        [Fact]
        public void TestDivisionPerZero()
        {
            var calc = InstantiateClass();

            Assert.Throws<DivideByZeroException>(() => { calc.Divide(3, 0); });
        }


        [Fact]
        public void TestHistoric()
        {
            var calc = InstantiateClass();

            calc.Sum(1, 2);
            calc.Subtract(1, 2);
            calc.Multiply(1, 2);
            calc.Divide(1, 2);

            var res = calc.Historic();

            Assert.NotEmpty(res);
            Assert.Equal(3, res.Count);
        }

        [Fact]
        public void TestGetDate()
        {
            var expectedDate = DateTime.Now.ToShortDateString();
            var calc = new Calculator(expectedDate);

            var res = calc.GetDate();

            Assert.Equal(expectedDate, res);
        }
    }
}
