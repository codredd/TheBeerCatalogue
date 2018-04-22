using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using TheBeerCatalogue.Controllers;

namespace TheBeerCatalogue.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Initialize controller
            HomeController controller = new HomeController();

            // Call the method
            ViewResult result = controller.Index() as ViewResult;

            //Assert the result
            Assert.IsNotNull(result);
        }
    }
}
