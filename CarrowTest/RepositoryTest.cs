using System.Collections.Generic;
using Carrow.Data;
using Carrow.Repositories;
using Moq;
using Xunit;

namespace CarrowTest
{
    public class RepositoryTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(5)]
        public void ShouldCallDatabaseLoadOnlyOnce(int amount)
        {
            var mock = new Mock<IDatabase>();
            mock.Setup(d => d.ReadCustomers(It.Is<int>(n => n == amount)))
                .Returns(new List<string> {"", "", ""});
            var repo = new Repository(mock.Object);
            repo.ReadCustomers(amount);
            mock.Verify(d => d.ReadCustomers(amount), Times.Once);
        }
    }
}