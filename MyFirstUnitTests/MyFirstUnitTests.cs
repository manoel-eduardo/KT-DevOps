using Xunit;

namespace MyFirstUnitTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            var util = new Util();
            Assert.Equal(4, util.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            var util = new Util();
            Assert.Equal(5, util.Add(2, 2));
        }
    }
}