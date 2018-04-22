using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using TheBeerCatalogue.Business;
using TheBeerCatalogue.Controllers;

namespace TheBeerCatalogue.Tests.Controllers
{
    [TestClass]
    public class BreweryControllerTest
    {
        private readonly BreweryInterface _breweryInterface = new BreweryFacade();

        [TestMethod]
        public void Index()
        {
            // Initialize controller
            BreweryController controller = new BreweryController(_breweryInterface);

            // Call the method
            ViewResult result = controller.Index() as ViewResult;

            //Assert the result
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetBrewery()
        {
            // Initialize controller
            BreweryController controller = new BreweryController(_breweryInterface);

            // Call the method
            JsonResult result = controller.GetBrewery() as JsonResult;

            //Assert the result
            Assert.IsNotNull(result);

        }
    }
}
