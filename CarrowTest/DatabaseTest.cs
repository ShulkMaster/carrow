using Carrow;
using Xunit;

namespace CarrowTest
{
    public class DatabaseTest
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ShouldLoadCustomers(int count)
        {
            var res = new Database().ReadCustomers(count);
            Assert.Equal("Juan", res[0]);
            Assert.Equal("Miguel", res[1]);
            Assert.Equal(count, res.Count);
        }
    }
}