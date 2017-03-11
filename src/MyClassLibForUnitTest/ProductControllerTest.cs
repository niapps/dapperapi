using DapperAPI.Controllers;
using DapperAPI.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClassLibForUnitTest
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    [TestFixture]
    public class ProductControllerTest
    {
        [Test]
        public void Test1()
        {
            ProductRepository repository = new ProductRepository();
            ProductController controller = new ProductController(repository);
            var x = controller.Get();
            Assert.AreEqual(0, x.ToList().Count);
        }
    }
}
