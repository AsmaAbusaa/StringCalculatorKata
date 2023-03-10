using System;
using String_Calculator;
using Xunit;

namespace StingCalculator.Tests
{
    public class StringCalculatorTests
    {
        StringCalculator calculator = new StringCalculator();
        int result = 0;
        [Fact]
        public void Add_EmptyString_ShouldRetrun0()
        {
            result = calculator.Add("");
            Assert.Equal(0, result);

        }

        [Fact]
        public void Add_OneNumber_RetrunTheSameNumber()
        {
            result = calculator.Add("1");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Add_TwoNumbers_RetrunTheirSum()
        {
            result = calculator.Add("1,2");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_UnKnownAmountOfNumbers_RetrunTheirSum()
        {
            result = calculator.Add("1,2,4,5,9");
            Assert.Equal(1 + 2 + 4 + 5 + 9, result);
        }

        [Theory]
        [InlineData("1\n2")]
        [InlineData("//;\n1;2")]
        public void Add_StringofNumbers_diffrentSyntax_RetrunTheirSum(string nums)
        {
            result = calculator.Add(nums);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_StringofNumbers_containeNegativeNumbers_RetrunError()
        {
            Action action = () => calculator.Add("1,4,-1,-4");

            Exception exception = Assert.Throws<Exception>(action);

            Assert.Equal("negatives not allowed:-1 -4 ", exception.Message);
        }

        [Fact]
        public void Add_StringofNumbers_ignoreBigNumbers()
        {
            result = calculator.Add("1,4,1001");
            Assert.Equal(5, result);

        }


    }
}
