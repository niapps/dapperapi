using Xunit;
using DapperAPI.Controllers;
using DapperAPI.Model;
using Moq;
using DapperAPI.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MyXunitTest
{
    public class MyTestsWithMocking
    {
        [Fact]
        public void TestUsingMoq()
        {
            // Arrange
            List<Product> hitlist = new List<Product>();
            hitlist.Add(new Product() { Name = "Fiets" });
            hitlist.Add(new Product() { Name = "Auto"});
            var mock = new Mock<IRepository<Product>>();
            mock.
                Setup(x => x.GetAll())
                .Returns(hitlist);
            
            ProductController controller = new ProductController(mock.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.Equal(2, result.ToList().Count);
        }
    }
}
