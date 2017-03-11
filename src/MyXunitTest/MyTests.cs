using DapperAPI.Controllers;
using DapperAPI.Repository;
using System.Linq;
using Xunit;

namespace MyXunitTest
{
    public class MyTests
    {
        [Fact]
        public void TestWithRealRepository()
        {
            // Arrange
            ProductRepository repository = new ProductRepository();
            ProductController controller = new ProductController(repository);

            // Act
            var result = controller.Get();

            // Assert
            Assert.Equal(2, result.ToList().Count);
        }
    }
}
