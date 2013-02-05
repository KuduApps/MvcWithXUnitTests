using Xunit;

namespace XUnitTests
{
    public class Tests
    {
        [Fact]
        public void ThisTestShouldFail()
        {
            Assert.Equal(4, 2 + 1);
        }
    }
}
