using System.Data;
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

        [Fact]
        public void ShouldTrowException()
        {
            var ex = Assert.Throws<DataException>(() => { new Database().ReadCustomers(7); });

            Assert.Equal("cannot open DB connection", ex.Message);
        }

        [Theory]
        [InlineData("Jose")]
        [InlineData("Marco")]
        public void ShouldInsertCustomers(string customer)
        {
            var db = new Database();
            var users = db.ReadCustomers(6);
            db.AddCustomer(customer);
            var updated = db.ReadCustomers(7);
            Assert.Equal(customer, updated[6]);
            Assert.True(updated.Count > users.Count);
        }
    }
}