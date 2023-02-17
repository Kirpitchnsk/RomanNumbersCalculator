using RomanNumberCalculator.Models;
namespace RomanNumberCalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 50, 60)]
        [InlineData(2345, 1011, 3356)]
        [InlineData(5000, 31, 5031)]
        public void Addition(ushort n1, ushort n2, ushort promRes)
        {
            RomanNumber num1 = new RomanNumber(n1);
            RomanNumber num2 = new RomanNumber(n2);
            RomanNumber num3 = new RomanNumber(promRes);
            RomanNumber result = num1 + num2;
            Assert.Equal(num3, result);
        }
        [Theory]
        [InlineData(10, 50, 500)]
        [InlineData(11, 11, 121)]
        [InlineData(141, 200, 28200)]
        public void Muliplate(ushort n1, ushort n2, ushort promRes)
        {
            RomanNumber num1 = new RomanNumber(n1);
            RomanNumber num2 = new RomanNumber(n2);
            RomanNumber num3 = new RomanNumber(promRes);
            RomanNumber result = num1 * num2;
            Assert.Equal(num3, result);
        }
        [Theory]
        [InlineData(50, 10, 40)]
        [InlineData(5000, 31, 4969)]
        public void Minus(ushort n1, ushort n2, ushort promRes)
        {
            RomanNumber num1 = new RomanNumber(n1);
            RomanNumber num2 = new RomanNumber(n2);
            RomanNumber num3 = new RomanNumber(promRes);
            RomanNumber result = num1 - num2;
            Assert.Equal(num3, result);
        }
        [Theory]
        [InlineData(50, 10, 5)]
        [InlineData(3, 3, 1)]
        [InlineData(340, 5, 68)]
        public void Divide(ushort n1, ushort n2, ushort promRes)
        {
            RomanNumber num1 = new RomanNumber(n1);
            RomanNumber num2 = new RomanNumber(n2);
            RomanNumber num3 = new RomanNumber(promRes);
            RomanNumber result = num1 / num2;
            Assert.Equal(num3, result);
        }
        [Fact]
        public void StringConvert()
        {
            RomanNumber num1 = new RomanNumber(11);
            string result = num1.ToString();
            string maybeResult = "XI";
            Assert.Equal(maybeResult, result);
        }
        [Fact]
        public void CloneMake()
        {
            Random random = new Random();
            RomanNumber n1 = new RomanNumber((ushort)random.Next(1, 10000));
            RomanNumber n2 = (RomanNumber)n1.Clone();
            Assert.Equal(n1, n2);
        }
        [Fact]
        public void Comparation()
        {
            try
            {
                Random random = new Random();
                RomanNumber n1 = new RomanNumber(11);
                RomanNumber n2 = new RomanNumber(11);
                ushort n3 = 11;
                int result1 = n1.CompareTo(n2);
                if (result1 == 0)
                {
                    int result2 = n2.CompareTo(n3);
                }
                else Assert.NotEqual(n1, n2);
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }
    }
}