using Xunit;

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
            int r = mathUtil.Add(2, 2);
            bool test = (r < 4) || (r > 4);
            Assert.False(test);
        }
    }
}