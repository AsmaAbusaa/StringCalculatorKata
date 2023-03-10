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



    }
}
