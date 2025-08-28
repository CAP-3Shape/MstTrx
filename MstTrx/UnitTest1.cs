using Xunit;

namespace MstTrx
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Do nothing; always succeed.
            throw new Exception(Environment.GetEnvironmentVariable("BRANCH_NAME"));
        }
    }
}