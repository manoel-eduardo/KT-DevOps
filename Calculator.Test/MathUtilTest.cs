using Xunit;
using Calculator;

namespace Calculator.Test
{
    public class MathUtilTest
    {
        [Fact]
        public void PassingTest()
        {
            var mathUtil = new MathUtil();
            Assert.Equal(4, mathUtil.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            var mathUtil = new MathUtil();
            Assert.Equal(5, mathUtil.Add(2, 2));
        }
    }
}